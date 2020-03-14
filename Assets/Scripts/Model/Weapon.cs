using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Model
{
    class Weapon : Item
    {
        public int Damage { get; set; }
        public Weapon(string title, int damage, CardType cardType) : base(title, cardType)
        {
            Damage = damage;
        }
    }
}
