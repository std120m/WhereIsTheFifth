using Assets.Scripts.Model;
using Assets.Scripts.ViewModel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public enum FieldType
{
    warriors,
    inventory,
    playerActive,
    enemyActive,
    noDrop
}

public class DropHandler : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    public FieldType FieldType;

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag == null)
            return;

        if (FieldType != FieldType.playerActive)
            return;

        CardMovement card = eventData.pointerDrag.GetComponent<CardMovement>();

        if (card)
        {
            Debug.Log(GameManager.Instance.ToString());
            (card.GetComponent<WarriorCardVM>().CardObject as Warrior).JoinToFight();
            card.DefaultParent = transform;
            Debug.Log($"Card {card.GetComponent<UnitCardVM>().CardObject.ToString()} join to fight");
            Debug.Log($"hand:");
            foreach (Unit warrior in GameManager.Instance.Game.HandWarriors)
            {
                Debug.Log(warrior.ToString());
            }
            Debug.Log($"activeField:");
            foreach (Unit warrior in GameManager.Instance.Game.ActiveWarriors)
            {
                Debug.Log(warrior.ToString());
            }
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (eventData.pointerDrag == null)
            return;

        if (FieldType != FieldType.playerActive)
            return;

        CardMovement card = eventData.pointerDrag.GetComponent<CardMovement>();

        if (card)
        {
            card.TempCardTransform = transform;
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (eventData.pointerDrag == null)
            return;

        CardMovement card = eventData.pointerDrag.GetComponent<CardMovement>();

        if (card && card.TempCardTransform == transform)
            card.TempCardTransform = card.DefaultParent;
    }
}
