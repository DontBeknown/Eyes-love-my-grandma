using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressToRecieve : MonoBehaviour
{
    public KeyCode KeyKode;
    public bool isPress = false, AutoSpawnMode = true;
    public SettingOnOff Setting;
    public Tutorial Hint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!Setting.issettingOn && !Hint.TutorialOn)
        {
            if (Input.GetKeyDown(KeyKode))
            {
                //Debug.Log("You press " + KeyKode);
                gameObject.GetComponent<SpriteRenderer>().color = new Color(0.85f, 0.85f, 0.85f, 1f);
                isPress = true;
            }
            if (Input.GetKeyUp(KeyKode))
            {
                //Debug.Log("You release " + KeyKode);
                gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
                isPress = false;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (AutoSpawnMode)
        {
            Destroy(collision.gameObject);
        }
    }
}
