using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Model
{
    class Warrior : Unit
    {
        public Effect Effect { get; set; }

        public Warrior(int damage, int protect, string name, int health, int maxCountItems, Effect effect, CardType cardType) : base(damage, protect, name, health, maxCountItems, cardType)
        {

        }
    }
}
