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

    public static Dictionary<string, Item> Items = new Dictionary<string, Item>
    {
        ["1"] = new Weapon { Title = "Меч", Description = "Тупо меч", Damage = 3, Cost = 12 }
    };

    public static Dictionary<string, Warrior> Warriors = new Dictionary<string, Warrior>
    {
        ["1"] = new Warrior { Name = "Вася", Description = "Тупо Вася", Damage = 2, Protect = 2, Health = 5, MaxCountItems = 3, Cost = 0, Effect = Effects["power"], Items = new List<Item> { Items["1"] } },
        ["2"] = new Warrior { Name = "Петя", Description = "Тупо Петя", Damage = 3, Protect = 1, Health = 6, MaxCountItems = 3, Cost = 0, Effect = Effects["weak"], Items = new List<Item> { Items["1"] } }
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
        new WarriorCardVM(){ CardObject = ObjectManager.Warriors["2"] }
    };
    public static List<UnitCardVM> MonsterCards;
    public static List<ArmorCardVM> ArmorCards;
    public static List<WeaponCardVM> WeaponCards = new List<WeaponCardVM>
    {
        new WeaponCardVM(){ CardObject = ObjectManager.Warriors["1"] },
        new WeaponCardVM(){ CardObject = ObjectManager.Warriors["1"] }
    };
}
