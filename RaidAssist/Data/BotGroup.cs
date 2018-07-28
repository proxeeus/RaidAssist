using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaidAssist.Data
{
    public class BotGroup
    {
        public int GroupIndex { get; set; }
        public int GroupLeaderId { get; set; }
        public string LeaderName { get; set; }
        public string GroupName { get; set; }
        public List<Bot> Members { get; set; }
        public string DisplayName
        {
            get
            {
                return string.Format("{0} ({1})", GroupName, LeaderName);
            }
        }
    }
}
