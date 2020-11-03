using System;

namespace ArenaFighter1
{
    class Round
    {
        // Round class is used for all game events and all round results.
        // Every game event and round is saved to the battle log.

        public void GameStart()
        {
            GameIntro();
            int playerId = PlayerCreate();
            int playerIdCheck = playerId;
            int opponentId = OpponentCreate(playerIdCheck);
            int opponentIdCheck = opponentId;
        }

        public void GameIntro()
        {
            Console.WriteLine("Welcome to the Star Wars Arena Fighter Battle Game!");
        }

        public int PlayerCreate()
        {
            // Player enter user name.
            Console.Write("Enter your name: ");

            Character player = new Character();

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
                    Console.WriteLine($"Welcome {player.Name}!");
                    player.Status = true;

                    // Add player to battle log.
                    Battle.BattleLog.Add($"[Battle log] Player user name: {player.Name}");
                }
            }

            // Player select character.
            Console.WriteLine("Select the character you want to be in the fight: ");
            Console.WriteLine("(1) Darth Vader       (2) Stormtrooper      (3) Tie Fighter");
            Console.WriteLine("(4) C-3PO             (5) R2-D2             (6) Millennium Falcon");

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
                    Console.WriteLine("Please choose a number between 1-6: ");
                    player.Status = false;
                }
                else
                {
                    // Randomize player strength.
                    player.Strength = 10 + Randomization.Random_1_6();

                    Console.WriteLine($"{player.Name}, you have choosen number {player.CharacterId} and will be the {player.CharacterName} with a randomized strength of {player.Strength}!");
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
            Character opponent = new Character();

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

            Console.WriteLine($"The Enemy got a randomized number of {opponent.CharacterId} and will be the {opponent.CharacterName} with a randomized strength of {opponent.Strength}");

            // Add randomized opponent character number to battle log.
            Battle.BattleLog.Add($"[Battle log] Enemy character number: {opponent.CharacterId}");

            // Add opponent character name to battle log.
            Battle.BattleLog.Add($"[Battle log] Enemy character name: {opponent.CharacterName}");

            // Add opponent strength to battle log.
            Battle.BattleLog.Add($"[Battle log] Enemy character strength: {opponent.Strength}");

            // TODO: Check before release.
            Battle.BattleList();

            return opponent.CharacterId;
        }
    }
}
