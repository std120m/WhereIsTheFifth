using Assets.Scripts.ViewModel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManagerScr : MonoBehaviour
{
    private void Awake()
    {
        CardManager.AllCards = new List<CardVM>();
        CardManager.AllCards.AddRange(CardManager.WarriorCards);
    }
}
