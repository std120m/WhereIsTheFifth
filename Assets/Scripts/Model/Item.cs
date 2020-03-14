using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Model
{   
    class Item : CardObject 
    {
        public string Title { get; set; }

        public Item(string title, CardType cardType) : base(cardType)
        {
            Title = title;
        }
    }
}
