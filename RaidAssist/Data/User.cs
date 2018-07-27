using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaidAssist.Data
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int AccountId { get; set; }
        public Character SelectedCharacter { get; set; }
        public List<Character> Characters { get; set; }
        public BotGroup SelectedBotGroup { get; set; }
    }
}
