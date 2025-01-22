using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Type : MonoBehaviour
{
    public string InputWord;
    public GameObject TypeField;
    public GameObject DisplayText;
    public void ChType()
    {
        InputWord = TypeField.GetComponent<Text>().text;
        if(InputWord == "Hi")
        {
            DisplayText.GetComponent<Text>().text = "Correct";
        }
        else
        {
            DisplayText.GetComponent<Text>().text = "Wrong";
        }
    }
}
