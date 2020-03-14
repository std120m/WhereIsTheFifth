using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Model
{
    public class Unit : CardObject
    {
        public List<Item> Items { get; set; }
        public int Damage { get; set; }
        public int Protect { get; set; }
        public string Name { get; set; }        
        public int Health { get; set; }
        public int MaxCountItems { get; set; }

        delegate void AttackHandler(Unit unit);
        event AttackHandler Atacked;

        public Unit(int damage, int protect, string name, string description, int health, int maxCountItems, CardType cardType) : base(description, cardType)
        {
            Damage = damage;
            Protect = protect;
            Name = name;
            Health = health;
            MaxCountItems = maxCountItems;
            Items = new List<Item>();
        }
        
        public void Attack(Unit unit)
        {
            Atacked?.Invoke(unit);
        }

        public void OnAttacked(Unit unit)
        {
            if(unit == this)
                Health -= unit.Damage;
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }
        public void RemoveItem(Item item)
        {
            Items.Remove(item);
        }
    }
}
