using System;

namespace Test
{
    internal interface IRng
    {
        int GetNumber();
    }

    internal class Rng : IRng
    {
        public int GetNumber()
        {
            return new Random().Next(3) + 1;
        }
    }

    internal class Constant : IRng
    {
        private readonly int _number;


        public Constant(int number)
        {
            _number = number;
        }


        public int GetNumber()
        {
            return _number;
        }
    }

}