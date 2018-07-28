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

        public override string DisplayName
        {
            get
            {
                if (IsLeader)
                    return base.DisplayName + " (Group Leader)";
                else
                    return base.DisplayName;
            }
        }
    }
}
