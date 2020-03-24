using Assets.Scripts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.UI;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.Scripts.ViewModel
{
    public class WarriorCardVM : UnitCardVM, IPointerClickHandler
    {
        public TextMeshProUGUI Cost;

        public delegate void ClickHandler(Warrior sender);
        public event ClickHandler Click;

        public void OnPointerClick(PointerEventData eventData)
        {
            Click?.Invoke(CardObject as Warrior);
        }

        public override void ShowCard(CardObject warrior)
        {
            base.ShowCard(warrior);
            Cost.text = (warrior as Warrior).Cost.ToString();
        }
    }
}
