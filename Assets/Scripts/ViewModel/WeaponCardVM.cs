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
    public class WeaponCardVM : CardVM
    {
        public TextMeshProUGUI Title;
        public TextMeshProUGUI Damage;
        public TextMeshProUGUI Cost;

        public override void ShowCard(CardVM weapon)
        {
            base.ShowCard(weapon);
            Title.text = (weapon as WeaponCardVM).Title.text;
            Damage.text = (weapon as WeaponCardVM).Damage.text;
            Cost.text = (weapon as WeaponCardVM).Cost.text;
        }
    }
}
