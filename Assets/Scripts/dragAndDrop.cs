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
       
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        
        canvasGroup.blocksRaycasts = true;
        canvasGroup.alpha = 1f;
    }

    public void OnDrag(PointerEventData eventData)
    {
        
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;

    }
    
    

    public void OnBeginDrag(PointerEventData eventData)
    {
       
        canvasGroup.blocksRaycasts = false;
        canvasGroup.alpha = .6f;
    }

    

}
