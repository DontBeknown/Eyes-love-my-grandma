using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IDropHandler
{
    public GameObject OldSalmaon, NewSalmon,SaltActionArea,InteractiveSalt,OldSalt,LastPan;
    public bool GrilledAction = false , SaltAction = false, FisnishDish = false;
    public Timer Countdown;
    public HintButton Hint;
    public AudioClip SoundClip;
    public AudioSource Source;
    public AudioClip GrillSound,TikSound;
    public GameObject FinishDish;
    void Start()
    {
        if(gameObject.name == "Grilled"){
            GrilledAction = true;
            NewSalmon.SetActive(false);
            //TimerSet.SetActive(false);
            SaltActionArea.SetActive(false);
            //InteractiveSalt.SetActive(false);

        }
        if(gameObject.name == "SaltAction")
        {
            SaltAction = true;
            
        }
        if(gameObject.name == "SalmonDish")
        {
            FinishDish.SetActive(false);
            FisnishDish = true;
        }
        
    }
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");
        if (eventData.pointerDrag != null)
        {
            

            if (GrilledAction)
            {
                Source.PlayOneShot(SoundClip);

                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;

                OldSalmaon.SetActive(false);
                NewSalmon.SetActive(true);
                SaltActionArea.SetActive(true);
                GrilledAction = false;
                Countdown.play = true;
                Source.PlayOneShot(GrillSound);
                Source.PlayOneShot(TikSound);
                Hint.kuykang = 2;
                Destroy(gameObject);
                
            }

            if (SaltAction)
            {
                Destroy(OldSalt);
                InteractiveSalt.SetActive(true);
            }

            if (FisnishDish)
            {
                Source.PlayOneShot(SoundClip);
                Destroy(eventData.pointerDrag);
                FinishDish.SetActive(true);
                LastPan.SetActive(false);
                Destroy(gameObject);
                FisnishDish = false;

            }
        }
    }
}
