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

        public WeaponCardVM(Weapon weapon, string imagePath) : base(weapon, imagePath)
        {
            Title.text = weapon.Title;
            Damage.text = weapon.Damage.ToString();
            Cost.text = weapon.Cost.ToString();
        }
    }
}
