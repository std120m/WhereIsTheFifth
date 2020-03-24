using Assets.Scripts.Model;
using Assets.Scripts.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public static class ObjectManager
{
    public static Dictionary<string, Effect> Effects = new Dictionary<string, Effect>
    {
        ["power"] = new Effect("Сильный", "Тупо сильнее", 3),
        ["weak"] = new Effect("Слабый", "Слабее, но лучше держит удар", -1, 3)
    };

    public static Dictionary<string, Weapon> Weapons = new Dictionary<string, Weapon>
    {
        ["1"] = new Weapon { Title = "Меч", Description = "Тупо меч", Damage = 3, Cost = 12 },
        ["2"] = new Weapon { Title = "Дубина", Description = "Тупо дубина", Damage = 1, Cost = 5 }
    };

    public static Dictionary<string, Warrior> Warriors = new Dictionary<string, Warrior>
    {
        ["1"] = new Warrior { Name = "Вася", Description = "Тупо Вася", Damage = 2, Protect = 2, Health = 5, MaxCountItems = 3, Cost = 0, Effect = Effects["power"], Weapon = (Weapons["1"].GetCopy() as Weapon) },
        ["2"] = new Warrior { Name = "Петя", Description = "Тупо Петя", Damage = 3, Protect = 1, Health = 6, MaxCountItems = 3, Cost = 0, Effect = Effects["weak"], Weapon = (Weapons["1"].GetCopy() as Weapon) },
        ["3"] = new Warrior { Name = "Коля", Description = "Тупо Коля", Damage = 2, Protect = 1, Health = 5, MaxCountItems = 3, Cost = 0, Effect = null, Weapon = (Weapons["2"].GetCopy() as Weapon) },
        ["4"] = new Warrior { Name = "Ваня", Description = "Тупо Ваня", Damage = 1, Protect = 3, Health = 3, MaxCountItems = 3, Cost = 0, Effect = null, Weapon = (Weapons["2"].GetCopy() as Weapon) }
    };
}

public static class CardManager
{
    public static List<CardVM> AllCards;
    public static List<CardVM> CatacombsCards;
    public static List<CardVM> TradesmanCards;
    public static List<CardVM> ForestsCards;
    public static List<WarriorCardVM> WarriorCards = new List<WarriorCardVM>
    {
        new WarriorCardVM(){ CardObject = ObjectManager.Warriors["1"] },
        new WarriorCardVM(){ CardObject = ObjectManager.Warriors["2"] },
        new WarriorCardVM(){ CardObject = ObjectManager.Warriors["3"] },
        new WarriorCardVM(){ CardObject = ObjectManager.Warriors["4"] }
    };
    public static List<UnitCardVM> MonsterCards;
    public static List<ArmorCardVM> ArmorCards;
    public static List<WeaponCardVM> WeaponCards = new List<WeaponCardVM>
    {
        new WeaponCardVM(){ CardObject = ObjectManager.Weapons["1"].GetCopy() }
    };
}
