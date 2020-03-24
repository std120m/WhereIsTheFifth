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

        public override string ToString()
        {
            return Title;
        }

        public override CardObject GetCopy()
        {
            Item copy = new Item();

            copy.Title = Title;
            copy.Cost = Cost;

            copy.CardType = CardType;
            copy.Description = Description;
            copy.Effect = Effect;

            return copy;
        }

        //public Item(string title, int cost, string description, CardType cardType) : base(description, cardType)
        //{
        //    Title = title;
        //    Cost = cost;
        //}
    }
}
