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

        public CardVM(CardObject cardObject, string imagePath)
        {
            CardObject = cardObject;
            Image = Resources.Load<Image>(imagePath);
            Image.preserveAspect = true;
            EffectName.text = CardObject.Effect.Name;
            EffectDescription.text = CardObject.Effect.Description;
            Descriprion.text = CardObject.Description;
        }
    }
}