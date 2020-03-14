using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Model
{
    public class Squad
    {
        public List<Warrior> Warriors { get; set; }
        public int Money { get; set; }

        public Squad()
        {
            Warriors = new List<Warrior>(); 
        }

        public void AddWarior(Warrior warrior)
        {
            Warriors.Add(warrior);
        }
        public void RemoveWarior(Warrior warrior)
        {
            Warriors.Remove(warrior);
        }
    }
}
