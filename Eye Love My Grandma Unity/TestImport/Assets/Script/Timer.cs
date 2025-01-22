using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float CurrentTime = 9;
    //public Slider slider;
    public CanvasGroup Burn1, Burn2;
    public GameObject Salt;
    public Animator PanAnim;
    public bool alreadyRun = false;
    public GameObject CountDownTimer,Circle;
    public bool play=false;
    public HintButton Hint;

    void Start()
    {
       // slider = slider.GetComponent<Slider>();
        Burn1 = Burn1.GetComponent<CanvasGroup>();
        Burn2 = Burn2.GetComponent<CanvasGroup>();
        Burn1.alpha = 0;
        Burn2.alpha = 0;
        PanAnim = PanAnim.GetComponent<Animator>();
        CountDownTimer.SetActive(false);
        Circle.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (play)
        {
            CountDownTimer.SetActive(true);

            
            Circle.SetActive(true);
            CountDownTimer.GetComponent<Text>().text = CurrentTime.ToString ("0");

            CurrentTime -= 1 * Time.deltaTime;
            //slider.value = CurrentTime;
            Burn1.alpha += 0.1f * Time.deltaTime;
            Burn2.alpha += 0.1f * Time.deltaTime;

            PanAnim.SetFloat("Timers", CurrentTime);

            if (CurrentTime <= 0 && !alreadyRun)
            {
                Salt.SetActive(true);
                alreadyRun = true;
                CountDownTimer.SetActive(false);
                Circle.SetActive(false);
                Hint.kuykang = 3;
                play = false;
            }
        }
    }


}
