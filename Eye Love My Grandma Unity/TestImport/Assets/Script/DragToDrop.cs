using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragToDrop : MonoBehaviour
{
    public bool isDraging;
    public LinkHitBox Enemy1 , Enemy2 , Enemy3 , Enemy4 , Enemy5, Enemy6;
    public GameObject GoLeft, GoRight;
    void Start()
    {
        GoLeft.SetActive(false);
        GoRight.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isDraging)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);
        }

        var boxCollider = gameObject.GetComponent<BoxCollider2D>();
        Collider2D[] overlap = Physics2D.OverlapAreaAll(boxCollider.bounds.min, boxCollider.bounds.max);
        /*if (overlap.Length > 1)
            Debug.Log(string.Format("Found {0} overlapping object(s)", overlap[0].name));*/

        for(int i = 1;i < overlap.Length; i++)
        {
            if (overlap[i].name != "สบู่") 
            {
                var Obj = GameObject.Find(overlap[i].name);
                Obj.GetComponent<LinkHitBox>().Damaged = true;
            }
        }

        if (Enemy1.Hp <= 0 && Enemy2.Hp <= 0 && Enemy3.Hp <= 0 && Enemy4.Hp <= 0 && Enemy5.Hp <= 0 && Enemy6.Hp <= 0)
        {
            GoLeft.SetActive(true);
            GoRight.SetActive(true);
        }
    }
    public void OnMouseDown()
    {
        isDraging = true;
    }
    public void OnMouseUp()
    {
        isDraging = false;
    }
}
