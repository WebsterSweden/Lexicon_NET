using System;

namespace ArenaFighter1
{
    class Character
    {
        // Character class is used for all characteristics of the player and the opponent.

        // Participants status.
        public bool Status { get; set; } = false;

        // Participant user name.
        public string Name { get; set; } = "";

        // Participant character number.
        public int CharacterId { get; set; } = 0;

        // Participant character name.
        public string CharacterName { get; set; } = "";

        // Participant character strength.
        public int Strength { get; set; } = 0;

        // Participant bonus.
        public int Bonus { get; set; } = 0;

        // Participant strike damage.
        public int Damage { get; set; } = 0;

        // Participant character and character number list.
        public void CharacterList(int characterChoice)
        {
            switch (characterChoice)
            {
                case 1:
                    CharacterId = 1;
                    CharacterName = "Darth Wader";
                    break;
                case 2:
                    CharacterId = 2;
                    CharacterName = "Stormtrooper";
                    break;
                case 3:
                    CharacterId = 3;
                    CharacterName = "Tie Fighter";
                    break;
                case 4:
                    CharacterId = 4;
                    CharacterName = "C-3PO";
                    break;
                case 5:
                    CharacterId = 5;
                    CharacterName = "R2-D2";
                    break;
                case 6:
                    CharacterId = 6;
                    CharacterName = "Millennium Falcon";
                    break;
            }
        }
    }
}
