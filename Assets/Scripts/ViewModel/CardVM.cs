using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assets.Scripts.Model;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Assets.Scripts.ViewModel
{
    public class CardVM : MonoBehaviour
    {
        public CardObject CardObject;
        public Image Image;
        public TextMeshProUGUI Descriprion;
        public TextMeshProUGUI EffectName;
        public TextMeshProUGUI EffectDescription;

        public virtual void ShowCard(CardObject card)
        {
            CardObject = card;
            if (CardObject.Effect == null)
            {
                EffectName.text = "";
                EffectDescription.text = "";
            }
            else
            {
                EffectName.text = CardObject.Effect.Name;
                EffectDescription.text = CardObject.Effect.Description;
            }
            Descriprion.text = CardObject.Description;
            Debug.Log($"Card {CardObject.ToString()} was show");
        }

        private void Start()
        {
        }
    }
}