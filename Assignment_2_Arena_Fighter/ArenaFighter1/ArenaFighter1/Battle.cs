using System;
using System.Collections.Generic;
using System.Text;

namespace ArenaFighter1
{
    class Battle
    {
        // Battle Class is used for the control of every game round and keeps a log of every game action.

        // Save all game actions in the battle log.
        public static List<object> BattleLog = new List<object>();

        // Output a list of all events from the battle log.
        public static void BattleList()
        {
            //BattleLog.Reverse();

            foreach (var battleEvent in BattleLog)
            {
                Console.WriteLine(battleEvent);
            }
        }
    }
}

// TODO:
// Battle log reference to both players and round events.
