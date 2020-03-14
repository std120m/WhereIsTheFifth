using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardMovement : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public GameObject TempCard;
    public Transform DefaultParent, TempCardTransform;

    void Awake()
    {
        TempCard = GameObject.Find("TempCard");
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        DefaultParent = transform.parent;
        TempCardTransform = transform.parent;
        TempCard.transform.SetParent(DefaultParent);
        transform.SetParent(DefaultParent.parent);
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector3 pos = Camera.allCameras[0].ScreenToWorldPoint(eventData.position);
        pos.z = 0;
        transform.position = pos;

        if (TempCard.transform.parent != TempCardTransform)
            TempCard.transform.SetParent(TempCardTransform);

        CheckPosition();
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.SetParent(DefaultParent);
        GetComponent<CanvasGroup>().blocksRaycasts = true;

        transform.SetSiblingIndex(TempCard.transform.GetSiblingIndex());
        TempCard.transform.SetParent(GameObject.Find("Canvas").transform);
        TempCard.transform.localPosition = new Vector3(2215, 0);
    }

    void CheckPosition()
    {
        int newIndex = TempCardTransform.childCount;

        for (int i = 0; i < TempCardTransform.childCount; i++)
        {
            if(transform.position.x < TempCardTransform.GetChild(i).position.x)
            {
                newIndex = i;

                if (TempCard.transform.GetSiblingIndex() < newIndex)
                    newIndex--;

                break;
            }
        }

        TempCard.transform.SetSiblingIndex(newIndex);
    }
}
