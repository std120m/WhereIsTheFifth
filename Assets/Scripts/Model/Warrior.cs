using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Model
{
    public class Warrior : Unit
    {
        public int Cost { get; set; }

        public override CardObject GetCopy()
        {
            Warrior copy = new Warrior();

            copy.Cost = Cost;

            copy.Armor = Armor;
            copy.Weapon = Weapon;
            copy.Items = Items;
            copy.Damage = Damage;
            copy.Protect = Protect;
            copy.Name = Name;
            copy.Health = Health;
            copy.MaxCountItems = MaxCountItems;

            copy.CardType = CardType;
            copy.Description = Description;
            copy.Effect = Effect;

            return copy;
        }

        public void JoinToFight()
        {
            GameManager.Instance.Game.ActiveWarriors.Add(this);
            GameManager.Instance.Game.HandWarriors.Remove(this);
        }

        //public Warrior(int damage, int protect, string name, int cost, string description, int health, int maxCountItems, CardType cardType, Effect effect = null) : base(damage, protect, name, description, health, maxCountItems, cardType, effect)
        //{
        //    Cost = cost;
        //}
    }
}
