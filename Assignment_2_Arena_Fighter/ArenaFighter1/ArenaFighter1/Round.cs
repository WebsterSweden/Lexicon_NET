using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ArenaFighter1
{
    class Round
    {
        // Round Class is used for all game events and all randomized results.
        // Every game event is saved to the battle log.

        public static void GameStart()
        {
            Console.WriteLine("Welcome to the Star Wars Arena Fighter Battle Game!");
            Console.Write("Enter your name: ");

            Character.ProponentStatus = false;

            while (Character.ProponentStatus == false)
            {
                // Accept all characters except empty string.
                Character.ProponentUserName = Console.ReadLine();
                if (Character.ProponentUserName == "")
                {
                    Console.Write("Please enter your name: ");
                }
                else
                {
                    Console.WriteLine($"Welcome {Character.ProponentUserName}!");
                    Character.ProponentStatus = true;
                }
            }

            // Add Proponent User Name to the battle log.
            Battle.BattleLog.Add($"[Battle log] Player User Name: {Character.ProponentUserName}");

            // Proponent select Character.
            Console.WriteLine("Select the Character you want to be in the fight: ");
            Console.WriteLine("(1) Darth Vader       (2) Stormtrooper      (3) Tie Fighter");
            Console.WriteLine("(4) C-3PO             (5) R2-D2             (6) Millennium Falcon");
            Console.Write("Choose the number representing your favourite Character: ");

            Character.ProponentChoiceOfCharacterStatus = false;

            // Proponent repeat input until valid input.
            while (Character.ProponentChoiceOfCharacterStatus == false)
            {
                string input = Console.ReadLine();
                Int32.TryParse(input, out int output);
                Character.ProponentSelectCharacter(output);

                if (Character.ProponentCharacterId != 1 && Character.ProponentCharacterId != 2 && Character.ProponentCharacterId != 3 && Character.ProponentCharacterId != 4 && Character.ProponentCharacterId != 5 && Character.ProponentCharacterId != 6)
                {
                    Console.Write("Please choose a number between 1-6: ");
                    Character.ProponentChoiceOfCharacterStatus = false;
                }
                else
                {
                    Console.WriteLine($"{Character.ProponentUserName}, you have choosen number {Character.ProponentCharacterId} and will be the {Character.ProponentCharacterName} Character!");
                    Character.ProponentChoiceOfCharacterStatus = true;

                    // Randomize Proponent Strength.
                    Character.ProponentStrength = 10 + Randomization.Random_1_6();
                    Console.WriteLine($"The {Character.ProponentCharacterName} has a randomized strength of: {Character.ProponentStrength}");

                    // Add Proponent choice of Character ID to battle log.
                    Battle.BattleLog.Add($"[Battle log] Player Selected Character ID: {Character.ProponentCharacterId}");

                    // Add Proponent choice of Character Name to battle log.
                    Battle.BattleLog.Add($"[Battle log] Player Character Name: {Character.ProponentCharacterName}");

                    // Add Proponent Strength to battle log.
                    Battle.BattleLog.Add($"[Battle log] Player Randomized Strength: {Character.ProponentStrength}");
                }
            }

            // Opponent randomize Character ID and bind it with associated Character Name.
            Character.OpponentRandomizationCharacter();
            Character.OpponentSelectCharacter(Character.OpponentCharacterId);

            Console.WriteLine($"Your Enemy got a randomized number of {Character.OpponentCharacterId} and this is the {Character.OpponentCharacterName} Character!");

            // Randomize Opponent Strength.
            Character.OpponentStrength = 10 + Randomization.Random_1_6();
            Console.WriteLine($"The Enemy {Character.OpponentCharacterName} have a strength of: {Character.OpponentStrength}");

            // Add Opponent Character ID to battle log.
            Battle.BattleLog.Add($"[Battle log] Enemy Randomized Character ID: {Character.OpponentCharacterId}");

            // Add Opponent Character Name to battle log.
            Battle.BattleLog.Add($"[Battle log] Enemy Character Name: {Character.OpponentCharacterName}");

            // Add Opponent Strength to battle log.
            Battle.BattleLog.Add($"[Battle log] Enemy Randomized Strength: {Character.OpponentStrength}");

            // Game is over.

            // Output a list of all events from the battle log.
            //Console.Clear();
            Battle.BattleList();
        }
    }
}

// TODO: Save every randomized event to the battle log.
// Random if proponent or opponent start the battle.
