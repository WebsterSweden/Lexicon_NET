using System;
using System.Collections.Generic;
using System.Text;

namespace ArenaFighter1
{
    class Character
    {
        // Character Class is used for all characteristics of the proponent and opponent player.

        // Proponent Player User Name.
        private static string proponentUserName;

        public static string ProponentUserName
        {
            get { return proponentUserName; }
            set { proponentUserName = value; }
        }

        // Proponent Player Status.
        private static bool proponentStatus;

        public static bool ProponentStatus
        {
            get { return proponentStatus; }
            set { proponentStatus = value; }
        }

        // Proponent Player Character ID.
        private static int proponentCharacterId;

        public static int ProponentCharacterId
        {
            get { return proponentCharacterId; }
            set { proponentCharacterId = value; }
        }

        // Proponent Player Character Name.
        private static string proponentCharacterName;

        public static string ProponentCharacterName
        {
            get { return proponentCharacterName; }
            set { proponentCharacterName = value; }
        }

        // Proponent Choose Character ID Status.
        private static bool proponentChoiceOfCharacterStatus;

        public static bool ProponentChoiceOfCharacterStatus
        {
            get { return proponentChoiceOfCharacterStatus; }
            set { proponentChoiceOfCharacterStatus = value; }
        }

        // Proponent Player Strength.
        private static int proponentStrength;

        public static int ProponentStrength
        {
            get { return proponentStrength; }
            set { proponentStrength = value; }
        }

        // Opponent Player User Name.
        private static string opponentUserName;

        public static string OpponentUserName
        {
            get { return opponentUserName; }
            set { opponentUserName = value; }
        }

        // Opponent Player Status.
        private static bool opponentStatus;

        public static bool OpponentStatus
        {
            get { return opponentStatus; }
            set { opponentStatus = value; }
        }

        // Opponent Player Character ID.
        private static int opponentCharacterId;

        public static int OpponentCharacterId
        {
            get { return opponentCharacterId; }
            set { opponentCharacterId = value; }
        }

        // Opponent Player Character Name.
        private static string opponentCharacterName;

        public static string OpponentCharacterName
        {
            get { return opponentCharacterName; }
            set { opponentCharacterName = value; }
        }

        // Opponent Player Strength.
        private static int opponentStrength;

        public static int OpponentStrength
        {
            get { return opponentStrength; }
            set { opponentStrength = value; }
        }

        // Proponent Player select a Character.
        public static void ProponentSelectCharacter(int proponentChoiceOfCharacter)
        {
            // Bind Choice of Character to Proponent Character ID.
            switch (proponentChoiceOfCharacter)
            {
                case 1:
                    Character.ProponentCharacterId = 1;
                    Character.ProponentCharacterName = "Darth Wader";
                    break;
                case 2:
                    Character.ProponentCharacterId = 2;
                    Character.ProponentCharacterName = "Stormtrooper";
                    break;
                case 3:
                    Character.ProponentCharacterId = 3;
                    Character.ProponentCharacterName = "Tie Fighter";
                    break;
                case 4:
                    Character.ProponentCharacterId = 4;
                    Character.ProponentCharacterName = "C-3PO";
                    break;
                case 5:
                    Character.ProponentCharacterId = 5;
                    Character.ProponentCharacterName = "R2-D2";
                    break;
                case 6:
                    Character.ProponentCharacterId = 6;
                    Character.ProponentCharacterName = "Millenium Falcon";
                    break;
            }
        }

        // Opponent bind randomized Character ID with associated Character Name.
        public static void OpponentSelectCharacter(int opponentChoiceOfCharacter)
        {
            switch (opponentChoiceOfCharacter)
            {
                case 1:
                    Character.OpponentCharacterId = 1;
                    Character.OpponentCharacterName = "Darth Wader";
                    break;
                case 2:
                    Character.OpponentCharacterId = 2;
                    Character.OpponentCharacterName = "Stormtrooper";
                    break;
                case 3:
                    Character.OpponentCharacterId = 3;
                    Character.OpponentCharacterName = "Tie Fighter";
                    break;
                case 4:
                    Character.OpponentCharacterId = 4;
                    Character.OpponentCharacterName = "C-3PO";
                    break;
                case 5:
                    Character.OpponentCharacterId = 5;
                    Character.OpponentCharacterName = "R2-D2";
                    break;
                case 6:
                    Character.OpponentCharacterId = 6;
                    Character.OpponentCharacterName = "Millenium Falcon";
                    break;
            }
        }

        // Opponent randomize Character ID.
        // Randomization continue as long as the Proponent and Opponent have the same Character ID.
        public static int OpponentRandomizationCharacter()
        {
            // Randomize a number for the Opponent.
            Character.OpponentCharacterId = Randomization.Random_1_6();

            Character.OpponentStatus = false;

            // Check if the Opponent number is the same as the Proponent number.
            while (Character.OpponentStatus == false)
            {
                Character.OpponentCharacterId = Randomization.Random_1_6();

                // Continue to randomize until the Opponent number is not the same as the Proponent number.
                if (Character.OpponentCharacterId == Character.ProponentCharacterId)
                {
                    Character.OpponentCharacterId = Randomization.Random_1_6();
                    Character.OpponentStatus = false;
                }
                else
                {
                    Character.OpponentStatus = true;
                }
            }

            return Character.OpponentCharacterId;
        }
    }
}

// TODO: Two player game.
// Check opponent character ID and randomize until it is not the same as the proponent character ID.
