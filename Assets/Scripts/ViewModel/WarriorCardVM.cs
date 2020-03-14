using Assets.Scripts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.UI;
using TMPro;

namespace Assets.Scripts.ViewModel
{
    class WarriorCardVM : UnitCardVM
    {
        public TextMeshProUGUI Cost;

        public WarriorCardVM(Warrior warrior, string imagePath) : base(warrior, imagePath)
        {
            Cost.text = warrior.Cost.ToString();
        }
    }
}
