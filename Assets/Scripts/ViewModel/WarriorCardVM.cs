using Assets.Scripts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

namespace Assets.Scripts.ViewModel
{
    public class WarriorCardVM : UnitCardVM
    {
        public TextMeshProUGUI Cost;

        public override void ShowCard(CardVM warrior)
        {
            base.ShowCard(warrior);
            Cost.text = (warrior.CardObject as Warrior).Cost.ToString();
        }
    }
}
