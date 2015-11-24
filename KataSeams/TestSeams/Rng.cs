using System;

namespace Test
{
    internal class Rng
    {
        public int GetNumber()
        {
            return new Random().Next(3) + 1;
        }
    }
}