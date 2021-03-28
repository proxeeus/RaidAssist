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
        public int InstCharges { get; set; }
        public long InstColor { get; set; }
        public int InstNoDrop { get; set; }
        public string InstCustomData { get; set; }
        public int OrnamentIcon { get; set; }
        public int OrnamentIdFile { get; set; }
        public int OrnamentHeroModel { get; set; }
        public int Augment1 { get; set; }
        public int Augment2 { get; set; }
        public int Augment3 { get; set; }
        public int Augment4 { get; set; }
        public int Augment5 { get; set; }
        public int Augment6 { get; set; }
    }
}
