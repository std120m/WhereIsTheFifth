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

        public override void ShowCard(CardVM armor)
        {
            base.ShowCard(armor);
            Title.text = (armor as ArmorCardVM).Title.text;
            Protect.text = (armor as ArmorCardVM).Protect.text;
            Cost.text = (armor as ArmorCardVM).Cost.text;
        }
    }
}
