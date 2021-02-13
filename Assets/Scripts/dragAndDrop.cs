using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class dragAndDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler 
{

    private RectTransform rectTransform;
    Canvas canvas;
    CanvasGroup canvasGroup;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvas = GameObject.Find("instructions").GetComponent<Canvas>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnPointerDown(PointerEventData eventData) {
        Debug.Log("down");
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("enDrag");
        canvasGroup.blocksRaycasts = true;
        canvasGroup.alpha = 1f;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("drag");
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;

    }
    
    

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("start");
        canvasGroup.blocksRaycasts = false;
        canvasGroup.alpha = .6f;
    }

    

}
