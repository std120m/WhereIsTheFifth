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

        public override void ShowCard(CardObject unit)
        {
            base.ShowCard(unit);
            Damage.text = (unit as Unit).Damage.ToString();
            Protect.text = (unit as Unit).Protect.ToString();
            Health.text = (unit as Unit).Health.ToString();
            Name.text = (unit as Unit).Name.ToString();
        }
    }
}

