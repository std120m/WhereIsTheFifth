using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Model
{
    public class Monster : Unit
    {
        public Monster(int damage, int protect, string name, string description, int health, int maxCountItems, CardType cardType) : base(damage, protect, name, description, health, maxCountItems, cardType)
        {

        }
    }
}
