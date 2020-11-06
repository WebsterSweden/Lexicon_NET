using System;

namespace ArenaFighter1
{
    class Round
    {
        // Round class is used for all game events and all round results.
        // Every game event and round is saved to the battle log.

        // Game status. Indicate if the current game is active.
        public static bool GameStatus { get; set; } = false;

        // Game count. Keep track on how many games played.
        public static int GameCount { get; set; } = 0;

        // Round status. Indicate if the current round is active.
        public static bool RoundStatus { get; set; } = false;

        // Round count. Keep track on how many rounds played.
        public static int RoundCount { get; set; } = 0;

        // Create player and opponent object for all methods in the round class.
        Character player = new Character();
        Character opponent = new Character();

        public void GameStart()
        {
            Console.WriteLine("Welcome to the Star Wars Arena Fighter Battle Game!");

            // Game has started.
            Round.GameStatus = true;
            Round.GameCount++;

            // Add game start to battle log.
            Battle.BattleLog.Add($"[Battle log] Star Wars Arena Fighter Battle Game Started");

            GameIntro();
        }

        public void GameIntro()
        {
            // Store player number as a constant value and not a randomizing value. Needed for later check.
            int playerId = PlayerCreate();
            int playerIdCheck = playerId;
            int opponentId = OpponentCreate(playerIdCheck);
            int opponentIdCheck = opponentId;
        }

        public int PlayerCreate()
        {
            // Player enter user name.
            Console.Write("\nEnter your name: ");

            // Player repeat input until valid input.
            player.Status = false;

            while (player.Status == false)
            {
                // Accept all characters except empty string and whitespace.
                player.Name = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(player.Name))
                {
                    Console.Write("Please enter your name: ");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"Welcome {player.Name}!");
                    player.Status = true;

                    // Add player to battle log.
                    Battle.BattleLog.Add($"[Battle log] Player user name: {player.Name}");
                }
            }

            // Player select character.
            Console.WriteLine("\n");
            Console.WriteLine("(1) Darth Vader       (2) Stormtrooper      (3) Tie Fighter");
            Console.WriteLine("(4) C-3PO             (5) R2-D2             (6) Millennium Falcon");
            Console.Write("\nSelect the character you want to be in the fight: ");

            // Player repeat input until valid input.
            player.Status = false;

            while (player.Status == false)
            {
                // Accept only integers.
                string input = Console.ReadLine();
                Int32.TryParse(input, out int output);

                // Bind player number with associated character.
                player.CharacterList(output);

                // Accept only number 1-6.
                // TODO: How to use regular expression?
                if (player.CharacterId != 1 && player.CharacterId != 2 && player.CharacterId != 3 && player.CharacterId != 4 && player.CharacterId != 5 && player.CharacterId != 6)
                {
                    Console.Write("Please choose a number between 1-6: ");
                    player.Status = false;
                }
                else
                {
                    // Randomize player strength.
                    player.Strength = 10 + Randomization.Random_1_6();

                    Console.Clear();

                    Console.WriteLine($"{player.Name}, you have chosen number {player.CharacterId} and will be the {player.CharacterName} \nwith a randomized strength of {player.Strength}");
                    Console.WriteLine("\n");
                    player.Status = true;

                    // Add player choice of character number to battle log.
                    Battle.BattleLog.Add($"[Battle log] Player character number: {player.CharacterId}");

                    // Add character name to battle log.
                    Battle.BattleLog.Add($"[Battle log] Player character name: {player.CharacterName}");

                    // Add player strength to battle log.
                    Battle.BattleLog.Add($"[Battle log] Player character strength: {player.Strength}");
                }
            }

            return player.CharacterId;
        }

        public int OpponentCreate(int playerCheck)
        {
            // Randomize opponent number.
            opponent.CharacterId = Randomization.Random_1_6();

            opponent.Status = false;

            // Check if it is the same character number as the player and keep repeating until it is not the same number.
            while (opponent.Status == false)
            {
                opponent.CharacterId = Randomization.Random_1_6();

                if (opponent.CharacterId == playerCheck)
                {
                    opponent.CharacterId = Randomization.Random_1_6();
                    opponent.Status = false;
                }
                else
                {
                    opponent.Status = true;
                }
            }

            // Bind opponent number with associated character.
            opponent.CharacterList(opponent.CharacterId);

            // Randomize opponent strength.
            opponent.Strength = 10 + Randomization.Random_1_6();

            Console.WriteLine($"The Enemy got a randomized number of {opponent.CharacterId} and will be the {opponent.CharacterName} \nwith a randomized strength of {opponent.Strength}");

            // Add randomized opponent character number to battle log.
            Battle.BattleLog.Add($"[Battle log] Enemy character number: {opponent.CharacterId}");

            // Add opponent character name to battle log.
            Battle.BattleLog.Add($"[Battle log] Enemy character name: {opponent.CharacterName}");

            // Add opponent strength to battle log.
            Battle.BattleLog.Add($"[Battle log] Enemy character strength: {opponent.Strength}");

            // Battle Start. The participant with the highest strength begin to strike.
            Battle battleStart = new Battle();
            battleStart.BattleStart(player, opponent);

            Battle.BattleList();

            return opponent.CharacterId;
        }
        public void GameContinue()
        {
            //player.Bonus = 10;
            //player.Strength = player.Bonus;
            //Console.WriteLine($"{player.Name}, you fight good and get 10 extra strength bonus!");

            OpponentCreate(opponent.CharacterId);
            Battle fightContinue = new Battle();
            fightContinue.Fight(player, opponent);
            //fightContinue.BattleStart(player, opponent);
        }
    }
}
