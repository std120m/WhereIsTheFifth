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
    public class MonsterBodyParts : Item
    {
        public PartsType Type { get; set; }

        public MonsterBodyParts(string title, int cost, string description, PartsType type, CardType cardType) : base(title, cost, description, cardType)
        {
            Type = type;
        }
    }
}
