using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Running : MonoBehaviour
{
    public float Speed = 5f;
    public PressToRecieve Button;
    public GameManager DaGame;
    public SettingOnOff Setting;
    public Tutorial Hint;
    public bool IsEndOftheLine;
    public string SceneName;
    /*public AudioClip SoundClip;
    public AudioSource Source;*/
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
            if (!Setting.issettingOn && !Hint.TutorialOn)
            {
                if (transform.position.x < -3)
                {
                    if (IsEndOftheLine)
                    {
                        SceneManager.LoadScene(SceneName);
                    }
                    Destroy(gameObject);
                }
                gameObject.transform.position = new Vector2(transform.position.x - Speed * Time.deltaTime, transform.position.y);
                if (transform.position.x < 2.9 && transform.position.x > 0.4 && Button.isPress)
                {
                    // Source.PlayOneShot(SoundClip);
                    DaGame.Score += 100;
                    Debug.Log("Hit");
                    if (IsEndOftheLine)
                    {
                        SceneManager.LoadScene(SceneName);
                    }
                    Destroy(gameObject);

                }
            }
        
        /*else
        {
            //Debug.Log("hi");
            gameObject.transform.position = new Vector2(transform.position.x - Speed * Time.deltaTime, transform.position.y);
            if (transform.position.x < -977.6f)
            {
                if (IsEndOftheLine)
                {
                    
                }
                Destroy(gameObject);
            }
            if (transform.position.x < -974.73f && transform.position.x > -977.6f && Button.isPress)
            {
                
                DaGame.Score += 100;
               
                if (IsEndOftheLine)
                {
                    
                }
                Destroy(gameObject);

            }
        }*/
    }
}
