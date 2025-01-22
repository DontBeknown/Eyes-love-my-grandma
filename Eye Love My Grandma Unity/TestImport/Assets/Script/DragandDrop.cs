using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class DragandDrop : MonoBehaviour ,IPointerDownHandler, IBeginDragHandler,IEndDragHandler,IDragHandler//, IDropHandler
{
    [SerializeField] private Canvas canvas;

    private CanvasGroup canvasgroup;
    private RectTransform rectTransform;
    public AudioClip SoundClip;
    public AudioSource Source;
    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasgroup = GetComponent<CanvasGroup>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        Source.PlayOneShot(SoundClip);
        //Debug.Log("OnBeginDrag");
        //canvasgroup.alpha = .8f;
        canvasgroup.blocksRaycasts = false;
    }
    public void OnDrag(PointerEventData eventData)
    {
        //Debug.Log("OnDrag");
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        
        //Debug.Log("OnEndDrag");
        canvasgroup.alpha = 1f;
        canvasgroup.blocksRaycasts = true;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnPointerDown");
    }

    /*public void OnDrop(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }*/
}
