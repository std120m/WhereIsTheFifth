using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Model
{
    public class Unit : CardObject
    {
        public Armor Armor { get; set; }
        public Weapon Weapon { get; set; }
        public List<Item> Items { get; set; }
        public int Damage { get; set; }
        public int Protect { get; set; }
        public string Name { get; set; }        
        public int Health { get; set; }
        public int MaxCountItems { get; set; }

        delegate void AttackHandler(Unit unit);
        event AttackHandler Atacked;

        //public Unit(int damage, int protect, string name, string description, int health, int maxCountItems = 3, Effect effect = null) : base(description, CardType.Warrior, effect)
        //{
        //    Damage = damage;
        //    Protect = protect;
        //    Name = name;
        //    Health = health;
        //    MaxCountItems = maxCountItems;
        //    Items = new List<Item>();
        //}
        
        public void Attack(Unit unit)
        {
            Atacked?.Invoke(unit);
        }

        public int SumDamage()
        {
            if (Weapon == null)
                return Damage;
            else
                return Damage + Weapon.Damage;
        }

        public void OnAttacked(Unit unit)
        {
            if (unit == this)
            {
                if(Armor != null && Armor.CurStrength > 0)
                    Armor.CurStrength -= unit.SumDamage() - Protect - Armor.Protect;
                else
                    Health -= unit.SumDamage() - Protect;
            }
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
