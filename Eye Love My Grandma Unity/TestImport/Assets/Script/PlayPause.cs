using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class PlayPause : MonoBehaviour
{
    public Sprite PlaySprite, PauseSprite;
    public Image Button;
    int ch = 0;
    public string nextScene;
    public int Time2Wait;

    void Start()
    {
        Button = Button.GetComponent<Image>();
        StartCoroutine(Wait2TheEnd());
    }
    public void PlayPauseButton()
    {
        ch++;
        if (ch % 2 == 0)
        {
            gameObject.GetComponent<VideoPlayer>().Play();
            Button.sprite = PauseSprite;
        }
        else
        {
            gameObject.GetComponent<VideoPlayer>().Pause();
            Button.sprite = PlaySprite;
        }
    }
    IEnumerator Wait2TheEnd()
    {
        yield return new WaitForSeconds(Time2Wait);
        SceneManager.LoadScene(nextScene);
    }
}
