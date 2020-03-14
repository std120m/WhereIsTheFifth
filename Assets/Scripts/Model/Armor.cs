using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Model
{
    class Armor : Item
    {
        public int Protect { get; set; }
        public Armor(string title, int protect, CardType cardType) : base(title, cardType)
        {
            Protect = protect;
        }
    }
}
