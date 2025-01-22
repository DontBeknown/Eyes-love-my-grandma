using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractSalt : MonoBehaviour
{
    public GameObject RealSalt, Salt01, Salt02, Salt;
    int sum = 0;
    public bool isDoSalt = false ,isFinish = false;
    public Animator DoSaltAnim;
    public HintButton Hint;
    public GameObject OldPan, NewPan;
    public AudioClip SoundClip;
    public AudioSource Source;
    void Start()
    {
    }

    void Update()
    {
        if (sum == 2 && !isFinish)
        {
            StartCoroutine(WaitSec());

            
        }
    }

    public void DoSalt()
    {
        if (!isDoSalt && sum < 2)
        {
            Source.PlayOneShot(SoundClip);
            sum++;
            StartCoroutine(Wait4Sec());

        }
    }

    IEnumerator Wait4Sec()
    {
        DoSaltAnim.SetBool("Dosalt", true);
        isDoSalt = true;
        yield return new WaitForSeconds(0.1f);
        RealSalt.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        RealSalt.SetActive(false);
        isDoSalt = false;
        if (sum == 1)
        {
            Salt01.SetActive(true);
        }
        else if (sum == 2)
        {
            Salt02.SetActive(true);
        }
        DoSaltAnim.SetBool("Dosalt", false);
    }

    IEnumerator WaitSec()
    {
        yield return new WaitForSeconds(0.3f);

        OldPan.SetActive(false);
        Salt01.SetActive(false);
        Salt02.SetActive(false);
        Salt.SetActive(false);
        Hint.kuykang = 4;
        NewPan.SetActive(true);
        isFinish = true;
    }
}
    
