using Knob_form.Interfaces;
using Timer = System.Windows.Forms.Timer;

namespace Knob_form
{
    public class TimersManager : ITimersManager
    {
        private Timer knobTimer;
        private Timer indicatorTimer;
        private Action<object, EventArgs> updateKnob;
        private Action<object, EventArgs> updateIndicator;


        public TimersManager(Action<object, EventArgs> updateKnobAction, Action<object, EventArgs> updateIndicatorAction)
        {
            updateKnob = updateKnobAction;
            updateIndicator = updateIndicatorAction;

            knobTimer = new Timer();
            indicatorTimer = new Timer();

            InitializeTimers();
        }

        private void InitializeTimers()
        {
            knobTimer.Interval = 3;
            knobTimer.Tick += new EventHandler(updateKnob);

            indicatorTimer.Interval = 10;
            indicatorTimer.Tick += new EventHandler(updateIndicator);
        }

        public void StartTimers()
        {
            knobTimer.Start();
            indicatorTimer.Start();
        }

        public void StopTimers()
        {
            knobTimer.Stop();
            indicatorTimer.Stop();
        }

        public void StartAnimationTimer()
        {
            knobTimer.Start();
        }

        public void StopAnimationTimer()
        {
            knobTimer.Stop();
        }

        public void StartSmallCircleTimer()
        {
            indicatorTimer.Start();
        }

        public void StopSmallCircleTimer()
        {
            indicatorTimer.Stop();
        }
    }
}
