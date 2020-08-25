using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SklepHajsWyswietlanko : MonoBehaviour
{
    Text hajstxt;
    public int hajs;
    string myString;
    void Start()
    {
        hajs = PlayerPrefs.GetInt("coins");
        hajstxt = GameObject.Find("TextHajsShop").GetComponent<Text>();
        myString = hajs.ToString();
        hajstxt.text = myString;
    }
    void Update()
    {
        
    }
}
