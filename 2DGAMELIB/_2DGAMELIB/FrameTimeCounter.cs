using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace _2DGAMELIB
{
    internal class FrameTimeCounter
    {
        private readonly Stopwatch sw = Stopwatch.StartNew();
        private long lastTicks;
        public double FrameMs { get; private set; }

        public void Frame()
        {
            long now = sw.ElapsedTicks;

            if (lastTicks != 0)
            {
                FrameMs = (now - lastTicks) * 1000.0 / Stopwatch.Frequency;
            }

            lastTicks = now;
        }
    }
}
