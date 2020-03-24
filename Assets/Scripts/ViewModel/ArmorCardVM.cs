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

        public override void ShowCard(CardObject armor)
        {
            base.ShowCard(armor);
            Title.text = (armor as Armor).Title;
            Protect.text = (armor as Armor).Protect.ToString();
            Cost.text = (armor as Armor).Cost.ToString();
        }
    }
}
