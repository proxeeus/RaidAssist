using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaidAssist.Data
{
    public class Bot : Character
    {
        public bool IsLeader { get; set; }
        public bool IsMember { get; set; }
        public int GroupId { get; set; }
        public int HealRotationId { get; set; }
        public bool IsHealRotationLeader { get; set; }
        public bool IsHealRotationMember { get; set; }

        public Inventory Inventory { get; set; }

        public override string DisplayName
        {
            get
            {
                if (IsLeader)
                    return base.DisplayName + " (GROUP LEADER)";
                else if (IsMember)
                    return base.DisplayName + " (MEMBER)";
                else
                    return base.DisplayName;
            }
        }
    }
}
