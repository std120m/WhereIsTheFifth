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

        public override CardObject GetCopy()
        {
            
            Weapon copy = new Weapon();

            copy.Damage = Damage;

            copy.Title = Title;
            copy.Cost = Cost;

            copy.CardType = CardType;
            copy.Description = Description;
            copy.Effect = Effect;

            return copy;
        }
        //public Weapon(string title, int cost, int damage, string description, CardType cardType) : base(title, cost, description, cardType)
        //{
        //    Damage = damage;
        //}
    }
}
