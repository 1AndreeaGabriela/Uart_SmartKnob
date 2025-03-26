using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Knob_form.Interfaces;
using Timer = System.Windows.Forms.Timer;

namespace Knob_form.Communication
{
    public class MockSerialCom : ISerialCom
    {
        public event Action<string> ErrorOccurred;

        private Timer _timer;
        private ISerialCom.DataReceivedHandler _dataReceivedCallback;
        private List<string> _messages;
        private int _currentMessageIndex = 0;
        private bool _isRunning = false;

        public MockSerialCom(int interval, ISerialCom.DataReceivedHandler dataReceivedCallback)
        {
            _dataReceivedCallback = dataReceivedCallback;
            _messages = new List<string>
            {
                // List of all your predefined messages
                "01 02 03 AA 00 BB 00 00",  // Clockwise
                "01 02 03 AA 00 BB 00 2D",  // Counterclockwise
                "01 02 03 AA 00 BB 00 5A",  // Clockwise
                "01 02 03 AA 01 BB 00 20",  // Counterclockwise
                "01 02 03 AA 00 BB 00 B4",  // Clockwise
                "01 02 03 AA 00 BB 00 E1",  // Counterclockwise
                "01 02 03 AA 01 BB 00 DE",  // Clockwise
                "01 02 03 AA 01 BB 00 3B",  // Counterclockwise
                "01 02 03 AA 00 BB 01 00",  // Clockwise
                "01 02 03 AA 00 BB 01 50",  // Counterclockwise
                "01 02 03 AA 01 BB 00 FF",  // Clockwise
                "01 02 03 AA 01 BB 00 5A",  // Counterclockwise
                "01 02 03 AA 00 BB 01 47",  // Clockwise
                "01 02 03 AA 00 BB 01 68",  // Counterclockwise
                "01 02 03 AA 00 BB 00 0E",  // Clockwise
                "01 02 03 AA 01 BB 01 40",  // Counterclockwise
                "01 02 03 AA 00 BB 01 50",  // Clockwise
                "01 02 03 AA 01 BB 01 0E"   // Counterclockwise
              
            /*    "01 02 03 AA 00 BB 00 00",  // Clockwise
                "01 02 03 AA 00 BB 00 03",  // Clockwise
                "01 02 03 AA 00 BB 00 06",  // Clockwise
                "01 02 03 AA 00 BB 00 09",  // Clockwise
                "01 02 03 AA 00 BB 00 0C",  // Clockwise
                "01 02 03 AA 00 BB 00 0F",  // Clockwise
                "01 02 03 AA 00 BB 00 12",  // Clockwise
                "01 02 03 AA 00 BB 00 15",  // Clockwise
                "01 02 03 AA 00 BB 00 18",  // Counterclockwise
                "01 02 03 AA 00 BB 00 1B",  // Clockwise
                "01 02 03 AA 00 BB 00 1E",  // Counterclockwise
                "01 02 03 AA 00 BB 00 21",  // Clockwise
                "01 02 03 AA 00 BB 00 24",  // Clockwise
                "01 02 03 AA 00 BB 00 27",  // Clockwise
                "01 02 03 AA 00 BB 00 2A",  // Clockwise
                "01 02 03 AA 00 BB 00 2D",  // Counterclockwise
                "01 02 03 AA 00 BB 00 30",  // Clockwise
                "01 02 03 AA 00 BB 00 33",  // Counterclockwise
                "01 02 03 AA 00 BB 00 36",  // Clockwise
                "01 02 03 AA 00 BB 00 39",  // Counterclockwise
                "01 02 03 AA 00 BB 00 3C",  // Clockwise
                "01 02 03 AA 00 BB 00 3F",  // Clockwise
                "01 02 03 AA 00 BB 00 42",  // Counterclockwise
                "01 02 03 AA 00 BB 00 45",  // Clockwise
                "01 02 03 AA 00 BB 00 48",  // Counterclockwise
                "01 02 03 AA 00 BB 00 4B",  // Clockwise
                "01 02 03 AA 00 BB 00 4E",  // Counterclockwise
                "01 02 03 AA 00 BB 00 51",  // Clockwise
                "01 02 03 AA 00 BB 00 54",  // Counterclockwise
                "01 02 03 AA 00 BB 00 57",  // Clockwise
                "01 02 03 AA 00 BB 00 5A",  // Counterclockwise
                "01 02 03 AA 00 BB 00 5D",  // Clockwise
                "01 02 03 AA 00 BB 00 60",  // Counterclockwise
                "01 02 03 AA 00 BB 00 63",  // Clockwise
                "01 02 03 AA 00 BB 00 66",  // Counterclockwise
                "01 02 03 AA 00 BB 00 69",  // Clockwise
                "01 02 03 AA 00 BB 00 6C",  // Counterclockwise
                "01 02 03 AA 00 BB 00 6F",  // Clockwise
                "01 02 03 AA 00 BB 00 72",  // Counterclockwise
                "01 02 03 AA 00 BB 00 75",  // Clockwise
                "01 02 03 AA 00 BB 00 78",  // Counterclockwise
                "01 02 03 AA 00 BB 00 7B",  // Clockwise
                "01 02 03 AA 00 BB 00 7E",  // Counterclockwise
                "01 02 03 AA 00 BB 00 81",  // Clockwise
                "01 02 03 AA 00 BB 00 84",  // Counterclockwise
                "01 02 03 AA 00 BB 00 87",  // Clockwise
                "01 02 03 AA 00 BB 00 8A",  // Counterclockwise
                "01 02 03 AA 00 BB 00 8D",  // Clockwise
                "01 02 03 AA 00 BB 00 90",  // Counterclockwise
                "01 02 03 AA 00 BB 00 93",  // Clockwise
                "01 02 03 AA 00 BB 00 96",  // Counterclockwise
                "01 02 03 AA 00 BB 00 99",  // Clockwise
                "01 02 03 AA 00 BB 00 9C",  // Counterclockwise
                "01 02 03 AA 00 BB 00 9F",  // Clockwise
                "01 02 03 AA 00 BB 00 A2",  // Counterclockwise
                "01 02 03 AA 00 BB 00 A5",  // Clockwise
                "01 02 03 AA 00 BB 00 A8",  // Counterclockwise
                "01 02 03 AA 00 BB 00 AB",  // Clockwise
                "01 02 03 AA 00 BB 00 AE",  // Counterclockwise
                "01 02 03 AA 00 BB 00 B1",  // Clockwise
                "01 02 03 AA 00 BB 00 B4",  // Counterclockwise
                "01 02 03 AA 00 BB 00 B7",  // Clockwise
                "01 02 03 AA 00 BB 00 BA",  // Counterclockwise
                "01 02 03 AA 00 BB 00 BD",  // Clockwise
                "01 02 03 AA 00 BB 00 C0",  // Counterclockwise
                "01 02 03 AA 00 BB 00 C3",  // Clockwise
                "01 02 03 AA 00 BB 00 C6",  // Counterclockwise
                "01 02 03 AA 00 BB 00 C9",  // Clockwise
                "01 02 03 AA 00 BB 00 CC",  // Counterclockwise
                "01 02 03 AA 00 BB 00 CF",  // Clockwise
                "01 02 03 AA 00 BB 00 D2",  // Counterclockwise
                "01 02 03 AA 00 BB 00 D5",  // Clockwise
                "01 02 03 AA 00 BB 00 D8",  // Counterclockwise
                "01 02 03 AA 00 BB 00 DB",  // Clockwise
                "01 02 03 AA 00 BB 00 DE",  // Counterclockwise
                "01 02 03 AA 00 BB 00 E1",  // Clockwise
                "01 02 03 AA 00 BB 00 E4",  // Counterclockwise
                "01 02 03 AA 00 BB 00 E7",  // Clockwise
                "01 02 03 AA 00 BB 00 EA",  // Counterclockwise
                "01 02 03 AA 00 BB 00 ED",  // Clockwise
                "01 02 03 AA 00 BB 00 F0",  // Counterclockwise
                "01 02 03 AA 00 BB 00 F3",  // Clockwise
                "01 02 03 AA 00 BB 00 F6",  // Counterclockwise
                "01 02 03 AA 00 BB 00 F9",  // Clockwise
                "01 02 03 AA 00 BB 00 FC",  // Counterclockwise
                "01 02 03 AA 00 BB 00 FF",  // Clockwise
                "01 02 03 AA 00 BB 01 02",  // Counterclockwise
                "01 02 03 AA 00 BB 01 05",  // Clockwise
                "01 02 03 AA 00 BB 01 08",  // Counterclockwise
                "01 02 03 AA 00 BB 01 0B",  // Clockwise
                "01 02 03 AA 00 BB 01 0E",  // Counterclockwise
                "01 02 03 AA 00 BB 01 11",  // Clockwise
                "01 02 03 AA 00 BB 01 14",  // Counterclockwise
                "01 02 03 AA 00 BB 01 17",  // Clockwise
                "01 02 03 AA 00 BB 01 1A",  // Counterclockwise
                "01 02 03 AA 00 BB 01 1D",  // Clockwise
                "01 02 03 AA 00 BB 01 20",  // Counterclockwise
                "01 02 03 AA 00 BB 01 23",  // Clockwise
                "01 02 03 AA 00 BB 01 26",  // Counterclockwise
                "01 02 03 AA 00 BB 01 29",  // Clockwise
                "01 02 03 AA 00 BB 01 2C",  // Counterclockwise
                "01 02 03 AA 00 BB 01 2F",  // Clockwise
                "01 02 03 AA 00 BB 01 32",  // Counterclockwise
                "01 02 03 AA 00 BB 01 35",  // Clockwise
                "01 02 03 AA 00 BB 01 38",  // Counterclockwise
                "01 02 03 AA 00 BB 01 3B",  // Clockwise
                "01 02 03 AA 00 BB 01 3E",  // Counterclockwise
                "01 02 03 AA 00 BB 01 41",  // Clockwise
                "01 02 03 AA 00 BB 01 44",  // Counterclockwise
                "01 02 03 AA 00 BB 01 47",  // Clockwise
                "01 02 03 AA 00 BB 01 4A",  // Counterclockwise
                "01 02 03 AA 00 BB 01 4D",  // Clockwise
                "01 02 03 AA 00 BB 01 50",  // Counterclockwise
                "01 02 03 AA 00 BB 01 53",  // Clockwise
                "01 02 03 AA 00 BB 01 56",  // Counterclockwise
                "01 02 03 AA 00 BB 01 59",  // Clockwise
                "01 02 03 AA 00 BB 01 5C",  // Counterclockwise
                "01 02 03 AA 00 BB 01 5F",  // Clockwise
                "01 02 03 AA 00 BB 01 62",  // Counterclockwise
                "01 02 03 AA 00 BB 01 65",  // Clockwise
                "01 02 03 AA 00 BB 01 68"   // Counterclockwise*/

            };

            _timer = new Timer
            {
                Interval = interval,
                Enabled = false // Timer starts disabled
            };

            _timer.Tick += OnTimedEvent; // Hook up the event
        }

        public void Open()
        {
            if (!_timer.Enabled)
            {
                _timer.Start();
                _isRunning = true;
            }
        }

        public bool IsOpen()
        {
            return _isRunning;
        }

        public void Close()
        {
            if (_timer.Enabled)
            {
                _timer.Stop();
                _isRunning = false;
            }
        }

        public void SetDataReceivedCallback(ISerialCom.DataReceivedHandler callback)
        {
            _dataReceivedCallback = callback;
        }

        private void OnTimedEvent(object sender, EventArgs e)
        {
            if (_dataReceivedCallback != null)
            {
                // Send the current message and move to the next
                string message = _messages[_currentMessageIndex];
                _dataReceivedCallback.Invoke(message);

                // Move to the next message, wrap around if necessary
                _currentMessageIndex = (_currentMessageIndex + 1) % _messages.Count;
            }
        }

        public Task SendAsync(string message)
        {
            throw new NotImplementedException();
        }
    }
}
