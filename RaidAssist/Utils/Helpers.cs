using RaidAssist.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaidAssist.Utils
{
    public static class Helpers
    {
        public static string GetLeaderName(int leaderId, List<Bot> bots)
        {
            var bot = (from b in bots where b.Id == leaderId select b).FirstOrDefault();

            return bot.Name;
        }
        public static string GetClassName(int classId)
        {
            switch (classId)
            {
                case 1: return "Warrior";
                case 2: return "Cleric";
                case 3: return "Paladin";
                case 4: return "Ranger";
                case 5: return "Shadow Knight";
                case 6: return "Druid";
                case 7: return "Monk";
                case 8: return "Bard";
                case 9: return "Rogue";
                case 10: return "Shaman";
                case 11: return "Necromancer";
                case 12: return "Wizard";
                case 13: return "Mage";
                case 14: return "Enchanter";
                case 15: return "Beastlord";
                case 16: return "Berserker";
            }
            return string.Empty;
        }
    }
}
