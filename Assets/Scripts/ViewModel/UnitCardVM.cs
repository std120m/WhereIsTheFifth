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
    public class UnitCardVM : CardVM
    {
        public TextMeshProUGUI Damage;
        public TextMeshProUGUI Protect;
        public TextMeshProUGUI Health;
        public TextMeshProUGUI Name;

        public UnitCardVM(Unit unit, string imagePath) : base(unit, imagePath)
        {
            Damage.text = unit.Damage.ToString();
            Protect.text = unit.Protect.ToString();
            Health.text = unit.Health.ToString();
            Name.text = unit.Name;
        }
    }
}

