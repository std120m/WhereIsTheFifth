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
    public class UnitCardVM : CardVM
    {
        public TextMeshProUGUI Damage;
        public TextMeshProUGUI Protect;
        public TextMeshProUGUI Health;
        public TextMeshProUGUI Name;

        public override void ShowCard(CardVM unit)
        {
            base.ShowCard(unit);
            Damage.text = (unit.CardObject as Unit).Damage.ToString();
            Protect.text = (unit.CardObject as Unit).Protect.ToString();
            Health.text = (unit.CardObject as Unit).Health.ToString();
            Name.text = (unit.CardObject as Unit).Name.ToString();
        }
    }
}

