using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BallText : MonoBehaviour
{
    public GameObject ballTextObj;
    private TextMeshPro tmp;

    public void Start()
    {
         tmp = ballTextObj.GetComponent<TextMeshPro>();
    }

    public string getText()
    {
        string text = tmp.text;
        Debug.Log(text);
        return text;
    }

}
