﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Model
{
    public enum CardType
    {
        Catacomb,
        Good,
        Warrior
    }

    public class CardObject
    {
        public string Description { get; set; }
        public CardType CardType { get; set; }
        public Effect Effect { get; set; }

        public CardObject(string description, CardType cardType, Effect effect = null)
        {
            CardType = cardType;
            Description = description;
        }
    }
}
