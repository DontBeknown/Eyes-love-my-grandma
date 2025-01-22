using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Texttrigger : MonoBehaviour
{
    public Tutorial tutorial;
    public EyeController Player;
    public bool FirsttimeCloseTutorail = true , Mission1Pass = false , Mission2Pass = false, Mission3Pass = false;
    public GameObject tutorialhint,CircleMission, UpdownMission, LeftRightMission, TiltedMission,NextScene;
    void Start()
    {
        Player.KnowHow2P = true;
        NextScene.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        /*if(!tutorial.TutorialOn && FirsttimeCloseTutorail)
         {
             tutorialhint.SetActive(true);
             FirsttimeCloseTutorail = false;
         }*/
        
        if (Player.KnowHow2P && !Mission1Pass)
        {
            tutorialhint.SetActive(false);
            CircleMission.SetActive(true);
            FirsttimeCloseTutorail = false;
        }
        if (Player.DoCircle && !Mission1Pass)
        {
            CircleMission.SetActive(false);
            UpdownMission.SetActive(true);
            Mission1Pass = true;
        }
        if (Player.DoUpDown && !Mission2Pass)
        {
            UpdownMission.SetActive(false);
            LeftRightMission.SetActive(true);
            Mission2Pass = true;
        }
        if (Player.DoLeftRight && !Mission3Pass)
        {
            LeftRightMission.SetActive(false);
            StartCoroutine(Textbox());
            Mission3Pass = true;
        }
        if (Player.DoTilted)
        {
            TiltedMission.SetActive(false);
            //Debug.Log("Finish");
            NextScene.SetActive(true);
        }

        
        
    }

    IEnumerator Textbox()
   {
        tutorialhint.SetActive(true);
        yield return new WaitForSeconds(2);
        tutorialhint.SetActive(false);
        TiltedMission.SetActive(true);

    }
}
