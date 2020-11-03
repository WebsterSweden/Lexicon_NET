using System;
using System.Collections.Generic;

namespace ArenaFighter1
{
    class Battle
    {
        // Battle class is used for the control of the game and saves a battle log of every game action.

        // Save all game actions in the battle log.
        public static List<object> BattleLog = new List<object>();

        // Output a list of all events from the battle log.
        public static void BattleList()
        {
            // TODO: Check before release.
            //Console.Clear();

            // Reverse the list.
            //BattleLog.Reverse();

            foreach (var battleEvent in BattleLog)
            {
                Console.WriteLine(battleEvent);
            }
        }
    }
}
