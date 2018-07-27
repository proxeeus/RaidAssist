using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaidAssist.User
{
    public class Character
    {
        public List<Bot> Bots { get; set; }
        public int Id { get; set; }
        public int ClassId { get; set; }
        public string Name { get; set; }
        public string DisplayName { get { return string.Format("{0} ({1})", Name, Utils.Helpers.GetClassName(ClassId)); } }
    }
}
