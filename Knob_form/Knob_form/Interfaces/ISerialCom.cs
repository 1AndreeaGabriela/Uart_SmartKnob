using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knob_form.Interfaces
{
    public interface ISerialCom
    {
        /*Event triggered when an error occurs*/
        event Action<string> ErrorOccurred;

        /*Opens the serial port and starts the reading thread*/
        void Open();

        /*Checks if the serial port is open*/
        bool IsOpen();

        /* Closes the serial port and stops the reading thread*/
        void Close();

        /*Sends a message through the serial port*/
        Task SendAsync(string message);

        /*Delegate for handling received data*/
        delegate void DataReceivedHandler(string data);

        /* Sets the callback for received data*/
        void SetDataReceivedCallback(DataReceivedHandler callback);
    }
}
