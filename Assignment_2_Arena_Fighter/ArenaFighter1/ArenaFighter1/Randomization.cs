using System;
using System.Collections.Generic;
using System.Text;

namespace ArenaFighter1
{
    class Randomization
    {
        public static Random randomGenerator = new Random(DateTime.Now.Millisecond);

        public static int Random_1_6()
        {
            //Random randomGenerator = new Random(DateTime.Now.Millisecond);
            int randomNumber_1_6 = randomGenerator.Next(1, 7);
            return randomNumber_1_6;
        }
    }
}
