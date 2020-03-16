using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Model
{
    public class Weapon : Item
    {
        public int Damage { get; set; }
        //public Weapon(string title, int cost, int damage, string description, CardType cardType) : base(title, cost, description, cardType)
        //{
        //    Damage = damage;
        //}
    }
}
