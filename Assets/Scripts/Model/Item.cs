using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Model
{   
    public class Item : CardObject 
    {
        public string Title { get; set; }
        public int Cost { get; set; }

        public Item(string title, int cost, string description, CardType cardType) : base(description, cardType)
        {
            Title = title;
            Cost = cost;
        }
    }
}
