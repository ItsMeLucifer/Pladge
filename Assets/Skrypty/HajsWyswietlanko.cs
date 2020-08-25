using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HajsWyswietlanko : MonoBehaviour
{
    public Text hajstxt;
    public GameObject coin;
    public int hajs;
    string myString;
    void Update()
    {
        if (PlayerPrefs.HasKey("coins"))
        {
            hajs = PlayerPrefs.GetInt("coins");
            Income();
        }
    }
    public void Income()
    {
        myString = hajs.ToString();
        hajstxt.text = myString;
    }

    public void pay(int amount)
    {
        if (this.hajs - amount >= -10)
            this.hajs -= amount;
        Income();
    }
}
