using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanBacteria : MonoBehaviour
{
    public GameObject Soup;
    public DragToDrop mouse;
    public float Hp = 1;

    public void OnMouseEnter()
    {
        Hp -= 0.4f;
    }
    public void OnMouseExit()
    {
        Hp -= 0.4f;
    }
}
