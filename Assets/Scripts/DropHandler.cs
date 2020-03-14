using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropHandler : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        CardMovement card = eventData.pointerDrag.GetComponent<CardMovement>();

        if (card)
            card.DefaultParent = transform;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (eventData.pointerDrag == null)
            return;

        CardMovement card = eventData.pointerDrag.GetComponent<CardMovement>();

        if (card)
            card.TempCardTransform = transform;
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
