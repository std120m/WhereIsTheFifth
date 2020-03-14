using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Model
{
    public enum PartsType
    {
        Head,
        Hand,
        Leg,
        Body
    }
    class MonsterBodyParts : Item
    {
        public PartsType Type { get; set; }

        public MonsterBodyParts(string title, PartsType type, CardType cardType) : base(title, cardType)
        {
            Type = type;
        }
    }
}
