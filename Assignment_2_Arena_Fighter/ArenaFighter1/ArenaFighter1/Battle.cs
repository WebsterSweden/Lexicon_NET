using System;
using System.Collections.Generic;

namespace ArenaFighter1
{
    class Battle
    {
        // Battle class is used for the control of the game and saves a battle log of every game action.

        // Create round object for all game and round methods in the round class.
        Round game = new Round();

        // Battle Start. The participant with the highest strength begin to strike.
        public void BattleStart(Character playerParameter, Character opponentParameter)
        {
            Character player = playerParameter;
            Character opponent = opponentParameter;

            player.Status = false;
            opponent.Status = false;

            // TODO: Higher number. Lower number. Same number.
            if (player.Strength >= opponent.Strength)
            {
                Console.WriteLine($"\n{player.Name}, you have the highest or even strength and start to strike");
                player.Status = true;
                opponent.Status = false;

                // Add Player start to fight to battle log.
                Battle.BattleLog.Add($"[Battle log] {player.Name} start to strike");
            }
            else
            {
                Console.WriteLine($"\nYour Enemy {opponent.CharacterName} have the highest strength and start to strike");
                player.Status = false;
                opponent.Status = true;

                // Add Opponent start to fight to battle log.
                Battle.BattleLog.Add($"[Battle log] {opponent.CharacterName} start to strike!");
            }

            Fight(player, opponent);
        }

        public void Fight(Character playerParameter, Character opponentParameter)
        {
            Character player = playerParameter;
            Character opponent = opponentParameter;

            // Round has started.
            Round.RoundStatus = true;

            //while (Round.RoundStatus == true)
            while (player.Status == true && Round.RoundStatus == true || opponent.Status == true && Round.RoundStatus == true)
            {
                if (player.Status == true)
                {
                    Console.Write($"\n{player.Name}, swing your Lightsaber! ");
                    Console.ReadLine();

                    player.Status = false;
                    opponent.Status = true;

                    // Deal damage to the enemy.
                    opponent.Damage = Randomization.RandomDamage();
                    opponent.Strength = opponent.Strength - opponent.Damage;
                    Console.Clear();
                    Console.WriteLine($"{player.Name}, you deal {opponent.Damage} of damage to {opponent.CharacterName}!");

                    // Do not output strength info if zero or less than zero.
                    if (opponent.Strength >= 0)
                    {
                        Console.WriteLine($"\n{opponent.CharacterName} now have {opponent.Strength} in strength");
                    }
                    else if (opponent.Strength <= 0)
                    {
                        Round.RoundCount++;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"You Win! You win this {Round.RoundCount} round!");
                        Console.ForegroundColor = ConsoleColor.Gray;

                        // Add player win to battle log.
                        Battle.BattleLog.Add($"[Battle log] {player.Name} win the round");

                        Console.Write($"\nDo you want to play another round and meet a new Enemy? (Y/N): ");
                        if (Console.ReadKey().Key == ConsoleKey.Y)
                        {
                            //Console.WriteLine("");
                            Console.Clear();
                            game.GameContinue();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("");
                            //Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"\nThank You {player.Name} for a good game!");
                            Console.Write($"\nThe Star Wars Arena Fighter Battle Game will show the battle log \nand then automatically quit: ");
                            //Console.ForegroundColor = ConsoleColor.Gray;
                            Console.ReadLine();
                            break;
                        }
                    }
                }
                else
                {
                    Console.Write($"\nEnemy {opponent.CharacterName}, swing your Lightsaber! ");
                    Console.ReadLine();
                    player.Status = true;
                    opponent.Status = false;

                    // Deal damage to the player.
                    player.Damage = Randomization.RandomDamage();
                    player.Strength = player.Strength - player.Damage;
                    Console.Clear();
                    Console.WriteLine($"{opponent.CharacterName} deal a damage of {player.Damage} to you!");

                    // Do not output strength info if zero or less than zero.
                    if (player.Strength >= 0)
                    {
                        Console.WriteLine($"\n{player.Name}, you now have {player.Strength} in strength");
                    }
                    else if (player.Strength <= 0)
                    {
                        Round.RoundCount++;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"\nYou are Dead! You loose this {Round.RoundCount} round!");
                        Console.ForegroundColor = ConsoleColor.Gray;

                        // Add opponent win to battle log.
                        Battle.BattleLog.Add($"[Battle log] {opponent.CharacterName} win the round");

                        Console.Write($"\nThe Star Wars Arena Fighter Battle Game will show the battle log \nand then automatically quit: ");
                        Console.ReadLine();
                        player.Status = false;
                        opponent.Status = false;
                        break;
                    }
                }
            }

            // Game end.
            GameEnd();
        }

        // Save all game actions in the battle log.
        public static List<object> BattleLog = new List<object>();

        // Output a list of all events from the battle log.
        public static void BattleList()
        {
            Console.Clear();

            // Reverse the list.
            //BattleLog.Reverse();

            foreach (var battleEvent in BattleLog)
            {
                Console.WriteLine(battleEvent);
            }
        }

        public static void GameEnd()
        {
            // Add round number to battle log.
            Battle.BattleLog.Add($"[Battle log] Number of rounds: {Round.RoundCount}");

            // Add Game end to battle log.
            Battle.BattleLog.Add($"[Battle log] Star Wars Arena Fighter Battle Game Ended");

            Round.GameStatus = false;
        }
    }
}
