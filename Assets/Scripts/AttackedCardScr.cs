using Assets.Scripts.Model;
using Assets.Scripts.ViewModel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AttackedCardScr : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        if (!GameManager.Instance.Game.IsPlayerTurn)
            return;

        WarriorCardVM warrior = eventData.pointerDrag.GetComponent<WarriorCardVM>();
        UnitCardVM enemy = GetComponent<UnitCardVM>();

        (warrior.CardObject as Warrior).OnAttack(enemy.CardObject as Unit, warrior.CardObject as Warrior);
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
