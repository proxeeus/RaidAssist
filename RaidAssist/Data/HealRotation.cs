using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaidAssist.Data
{
    public class HealRotation
    {
        public int Id { get; set; }
        public int BotId { get; set; }
        public int Interval { get; set; }
        public int FastHeals { get; set; }
        public int AdaptiveTargeting { get; set; }
        public int CastingOverride { get; set; }
        public float SafeHPBase { get; set; }
        public float SafeHPCloth { get; set; }
        public float SafeHPLeather { get; set; }
        public float SafeHPChain { get; set; }
        public float SafeHPPlate { get; set; }
        public float CriticalHPBase { get; set; }
        public float CriticalHPCloth { get; set; }
        public float CriticalHPLeather { get; set; }
        public float CriticalHPChain { get; set; }
        public float CriticalHPPlate { get; set; }

        public List<Bot> Members { get; set; }
        public List<Character> Targets { get; set; }

    }
}
