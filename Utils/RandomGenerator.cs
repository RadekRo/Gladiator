using System;

namespace Gladiator.Utils
{
    public class RandomGenerator
    {
        public static int GetRandomNumber(int rangeStart, int rangeEnd)
        {
            Random random = new Random();
            return random.Next(rangeStart, rangeEnd);
        }
    }
}
