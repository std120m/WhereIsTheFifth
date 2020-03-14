using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Model
{
    public class Effect
    {
        public int BonusDamage { get; set; }
        public int BonusProtect { get; set; }
        public int BonusItemSlot { get; set; }
        public int BonusHealth { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
