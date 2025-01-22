using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public AudioSource theMusic;

    public bool startPlaying;

    public BeastHolder theBS;

    public static Game instance;

    public int currentScore;
    public int Scorepernote;

    public int currentMultiplier;
    public int multiplierTracker;
    public int[] multiplierThresholds;

    public Text scoreText;
    public Text multiText;


    void Start()
    {
        instance = this;

        scoreText.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        if (!startPlaying)
        {
            if (Input.anyKeyDown)
            {
                startPlaying = true;
                theBS.hasStarted = true;
                theMusic.Play();
            }
        }
    }

    public void NoteHit()
    {
        Debug.Log("Hit!!!!");

      /*  if (currentMultiplier - 1 < multiplierThresholds.Length)
        {


            multiplierTracker++;

            if (multiplierThresholds[currentMultiplier - 1] <= multiplierTracker)
            {
                multiplierTracker = 0;
                currentMultiplier++;
            }
        }*/

       // multiText.text = "Multiplier: x" + currentMultiplier;

        currentScore += Scorepernote ;
        scoreText.text = "Score: " + currentScore;
    }
    public void NoteMissed()
    {
        Debug.Log("Miss LOL");
        /*currentMultiplier = 1;
        multiTextltiplier = 0;
        multiText.text = "Multiplier: x" + currentMultiplier;*/
    }
}
