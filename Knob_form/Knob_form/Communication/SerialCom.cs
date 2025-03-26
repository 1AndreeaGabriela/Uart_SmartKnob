using System.IO.Ports;
using Knob_form.Interfaces;

public class SerialCom : ISerialCom
{
    public event Action<string> ErrorOccurred;
    private SerialPort _serialPort;
    private Thread _readThread;
    private bool _keepReading;
    private ISerialCom.DataReceivedHandler _dataReceivedCallback;

    public SerialCom(string portName, int baudRate, ISerialCom.DataReceivedHandler dataReceivedCallback)
    {
        _serialPort = new SerialPort
        {
            PortName = portName,
            BaudRate = baudRate,
            Parity = Parity.None,
            DataBits = 8,
            StopBits = StopBits.One,
            Handshake = Handshake.None,
            ReadTimeout = 100000,
            WriteTimeout = 100000
        };

        _dataReceivedCallback = dataReceivedCallback;
    }

    public void Open()
    {
        if (!_serialPort.IsOpen)
        {
            _serialPort.Open();
            _keepReading = true;
            _ = ReadDataAsync(); 
        }
    }
    public bool IsOpen()
    {
        return _serialPort.IsOpen;
    }

    public void Close()
    {
        if (_serialPort.IsOpen)
        {
            _keepReading = false;
            _serialPort.Close();
        }
    }
    public async Task SendAsync(string message)
    {
        try
        {
            if (_serialPort.IsOpen)
            {
                //_serialPort.WriteLine(message);
                //await Task.Run(() => _serialPort.WriteLine(message));
                foreach (char c in message)
                {
                    _serialPort.Write(c.ToString());
                    await Task.Delay(50);
                }
                _serialPort.Write("\n");
            }
            else
            {
                ErrorOccurred?.Invoke("Serial port is not open.");
            }
        }
        catch (Exception ex)
        {
            ErrorOccurred?.Invoke($"Error sending message: {ex.Message}");
        }
    }

    private async Task ReadDataAsync()
    {
        await Task.Run(() =>
        {
            try
            {
                while (_keepReading)
                {
                    try
                    {   // Clean up the data buffer to prevent overflow
                       //_serialPort.DiscardInBuffer();
                        string data = _serialPort.ReadLine();
                        _dataReceivedCallback?.Invoke(data);
                    }
                    catch (TimeoutException) { }
                    catch (IOException) { break; }
                    catch (InvalidOperationException) { break; }
                    catch (Exception ex)
                    {
                        ErrorOccurred?.Invoke($"Error reading from serial port: {ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorOccurred?.Invoke($"Error in read thread: {ex.Message}");
            }
        });
    }

    /* Sets the callback for received data */
    public void SetDataReceivedCallback(ISerialCom.DataReceivedHandler callback)
    {
        _dataReceivedCallback = callback;
    }
}
