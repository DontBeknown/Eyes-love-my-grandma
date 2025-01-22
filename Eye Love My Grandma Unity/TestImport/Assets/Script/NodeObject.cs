using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeObject : MonoBehaviour
{
    public bool CanBePress;

    public KeyCode KeyToPress;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyToPress))
        {
            if (CanBePress)
            {
                gameObject.SetActive(false);
                Game.instance.NoteHit();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Activator")
        {
            CanBePress = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
            if (other.tag == "Activator")
            {
                CanBePress = false;
                Game.instance.NoteMissed();
            }
    }
}
