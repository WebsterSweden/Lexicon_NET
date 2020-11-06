using System;

namespace ArenaFighter1
{
    class Randomization
    {
        // Randomization class is used for all random methods.

        static Random randomGenerator = new Random(DateTime.Now.Millisecond);

        // Generate random whole number between 1 and 6.
        public static int Random_1_6()
        {
            int randomNumber_1_6 = randomGenerator.Next(1, 7);
            return randomNumber_1_6;
        }

        // Generate random whole number between 4 and 7.
        // Used for damage when striking.
        public static int RandomDamage()
        {
            int randomDamage = randomGenerator.Next(7, 11);
            return randomDamage;
        }
    }
}
