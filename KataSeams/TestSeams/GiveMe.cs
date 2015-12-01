using System;

namespace Test
{
    internal class GiveMe
    {
        private readonly IRng _rng;

        public GiveMe(IRng rng)
        {
            _rng = rng;
        }

        public string Advice()
        {
            var number = _rng.GetNumber();
            string ret;
            switch (number)
            {
                case    1:
                    ret = "HearNoEvil";
                    break;
                case    2:
                    ret = "SayNoEvil";
                    break;
                case    3:
                    ret = "DoNoEvil";
                    break;
                default:
                    throw new Exception("What did you do?");
            }
            return ret;
        }
    }
}