﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Model
{
    public class Armor : Item
    {
        public int Protect { get; set; }
        public int MaxStrength { get; set; }
        public int CurStrength { get; set; }

        public override CardObject GetCopy()
        {
            
            Armor copy =new Armor();

            copy.Protect = Protect;
            copy.MaxStrength = MaxStrength;
            copy.CurStrength = CurStrength;

            copy.Title = Title;
            copy.Cost = Cost;

            copy.CardType = CardType;
            copy.Description = Description;
            copy.Effect = Effect;

            return copy;
        }
        //public Armor(string title, int cost, string description, int protect, CardType cardType) : base(title, cost, description, cardType)
        //{
        //    Protect = protect;
        //}
    }
}
