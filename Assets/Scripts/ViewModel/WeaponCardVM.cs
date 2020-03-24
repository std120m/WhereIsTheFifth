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
    public class WeaponCardVM : CardVM
    {
        public TextMeshProUGUI Title;
        public TextMeshProUGUI Damage;
        public TextMeshProUGUI Cost;

        public override void ShowCard(CardObject weapon)
        {
            base.ShowCard(weapon);

            Title.text = (weapon as Weapon).Title;
            Damage.text = (weapon as Weapon).Damage.ToString();
            Cost.text = (weapon as Weapon).Cost.ToString();
        }
    }
}
