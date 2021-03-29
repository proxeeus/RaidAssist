using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaidAssist.Data
{
    public class InventoryEntry
    {
        public int Id { get; set; }
        public int BotId { get; set; }
        public int SlotId { get; set; }
        public int ItemId { get; set; }
        public string ItemName { get; set; }
    }
}
