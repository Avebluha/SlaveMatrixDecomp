using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace _2DGAMELIB
{
    internal class RealFpsCounter
    {
        private readonly Stopwatch sw = Stopwatch.StartNew();
        private int frames;
        private long lastTicks;
        public double Value { get; private set; }

        public void Frame()
        {
            frames++;

            long now = sw.ElapsedTicks;
            long delta = now - lastTicks;

            if (delta >= Stopwatch.Frequency)
            {
                Value = frames / (delta / (double)Stopwatch.Frequency);
                frames = 0;
                lastTicks = now;
            }
        }
    }
}
