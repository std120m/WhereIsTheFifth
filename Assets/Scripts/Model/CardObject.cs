using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Model
{
    public enum CardType
    {
        Catacomb,
        Good,
        Warrior
    }

    class CardObject
    {
        public CardType CardType { get; set; }

        public CardObject(CardType cardType)
        {
            CardType = cardType;
        }
    }
}
