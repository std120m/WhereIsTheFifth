using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

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

        public delegate void AttackHandler(Unit defender, Unit attacker);
        public event AttackHandler Attack;

        public delegate void DeathHandler(Unit unit);
        public event DeathHandler Death;

        public delegate void UpdateHandler(CardObject sender);
        public event UpdateHandler UpdateInfo;

        public override string ToString()
        {
            return Name;
        }

        public override CardObject GetCopy()
        {
            
            Unit copy = new Unit();

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

        //public Unit(int damage, int protect, string name, string description, int health, int maxCountItems = 3, Effect effect = null) : base(description, CardType.Warrior, effect)
        //{
        //    Damage = damage;
        //    Protect = protect;
        //    Name = name;
        //    Health = health;
        //    MaxCountItems = maxCountItems;
        //    Items = new List<Item>();
        //}

        public void OnAttack(Unit defender, Unit attacker)
        {
            Attack?.Invoke(defender, attacker);
        }

        public int SumDamage()
        {
            int resultDamage = Damage;

            if (Weapon != null)
                resultDamage += Weapon.Damage;
            if (Effect != null)
                resultDamage += Effect.BonusDamage;

            return resultDamage;
        }

        public int SumProtect()
        {
            int resultProtect = Protect;

            if (Effect != null)
                resultProtect += Effect.BonusProtect;

            return resultProtect;
        }
        
        public void WasAttacked(Unit defender, Unit attacker)
        {
            if (defender == this)
            {
                int oldHealth = Health;
                if (Armor != null && Armor.CurStrength > 0)
                    Armor.CurStrength -= (attacker.SumDamage() - SumProtect() - Armor.Protect < 0) ? 0 : attacker.SumDamage() - SumProtect() - Armor.Protect;
                else
                    Health -= (attacker.SumDamage() - SumProtect() < 0) ? 0 : attacker.SumDamage() - SumProtect();

                if (Health <= 0)
                {
                    OnDeath();
                    return;
                }

                Debug.Log($"{defender.ToString()} was attacked by {attacker.ToString()} (получено урона - {oldHealth - Health})");

                UpdateInfo?.Invoke(defender);
            }
        }

        public void OnDeath()
        {
            Death?.Invoke(this);
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
