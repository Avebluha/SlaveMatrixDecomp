using System;
using System.Globalization;

namespace _2DGAMELIB
{
    public static class Rng
    {
    	public static MyRandom XS = new MyRandom((uint)(Environment.TickCount + DateTime.Now.ToBinary()));
    }
}
