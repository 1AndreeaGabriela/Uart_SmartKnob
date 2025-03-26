using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knob_form.Interfaces
{
    public interface ITimersManager
    {
        /* Method to start both timers*/
        void StartTimers();

        /*Method to stop both timers*/
        void StopTimers();

        /*Method to start the knob animation timer*/
        void StartAnimationTimer();

        /*Method to stop the knob animation timer*/
        void StopAnimationTimer();

        /*Method to start the indicator timer*/
        void StartSmallCircleTimer();

        /* Method to stop the indivcator timer*/
        void StopSmallCircleTimer();
    }
}
