using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintButton : MonoBehaviour
{
    public GameObject Hint1, Hint2, Hint3, Hint4, Hint5;
    public int kuykang=1, kangnum = 1;
    public bool isPress = false;
    //public string KangString = "Hint";
    // Start is called before the first frame update
    void Start()
    {
        Hint1.SetActive(false);
        Hint2.SetActive(false);
        Hint3.SetActive(false);
        Hint4.SetActive(false);
        Hint5.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isPress)
        {
            if (kuykang == 1)
            {
                Hint1.SetActive(true);
            }
            else if (kuykang == 2)
            {
                Hint1.SetActive(false);
                Hint2.SetActive(true);
            }
            else if (kuykang == 3)
            {
                Hint2.SetActive(false);
                Hint3.SetActive(true);
            }
            else if (kuykang == 4)
            {
                Hint3.SetActive(false);
                Hint4.SetActive(true);
            }
            else if (kuykang == 5)
            {
                Hint4.SetActive(false);
                Hint5.SetActive(true);
            }
        }
    }

    public void HintPlus()
    {
        kangnum++;

        if (kangnum % 2 == 1)
        {
            isPress = true;
        }
        else
        {
            Hint1.SetActive(false);
            Hint2.SetActive(false);
            Hint3.SetActive(false);
            Hint4.SetActive(false);
            Hint5.SetActive(false);
            isPress = false;
        }
    }

}
