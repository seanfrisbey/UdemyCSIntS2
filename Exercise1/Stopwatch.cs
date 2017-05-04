using System;

namespace Exercise1
{
    class Stopwatch
    {
        private bool _started = false;
        private DateTime _startTime;
        private DateTime _stopTime;

        public Stopwatch()
        {
            _startTime = new DateTime();
            _stopTime = new DateTime();
        }

        public void Start()
        {
            if (_started)
            {
                throw new InvalidOperationException("A stopwatch is already started. Please stop the current " +
                                                    "stopwatch to start a new one.");
            }

            _startTime = DateTime.Now;
            _started = true;
        }

        public void Stop()
        {
            _stopTime = DateTime.Now;
            _started = false;
        }

        public TimeSpan GetDuration()
        {
            return  _stopTime-_startTime;
        }
    }
}