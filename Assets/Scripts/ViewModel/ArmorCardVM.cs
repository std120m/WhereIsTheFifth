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
    public class ArmorCardVM : CardVM
    {
        public TextMeshProUGUI Title;
        public TextMeshProUGUI Protect;
        public TextMeshProUGUI Cost;

        public ArmorCardVM(Armor armor, string imagePath) : base(armor, imagePath)
        {
            Title.text = armor.Title;
            Protect.text = armor.Protect.ToString();
            Cost.text = armor.Cost.ToString();
        }
    }
}
