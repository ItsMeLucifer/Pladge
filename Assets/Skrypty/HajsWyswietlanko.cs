using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HajsWyswietlanko : MonoBehaviour
{
    Text hajstxt;
    public int hajs;
    string myString;
    void Start()
    {
        hajstxt = GameObject.Find("TextHajs").GetComponent<Text>();
    }
    void Update()
    {
    }
    public void Income()
    {
        myString = hajs.ToString();
        hajstxt.text = myString;
    }
}
