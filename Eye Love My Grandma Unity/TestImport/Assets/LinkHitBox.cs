using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkHitBox : MonoBehaviour
{
    public float Hp = 1;
    public bool Damaged = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Damaged)
        {
            Hp -= 0.05f;
            Damaged = false;
        }
        gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, Hp);
    }
}
