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
        //DontDestroyOnLoad(hajstxt);
        //Chuj wie, generalnie chcialem zrobic aby nie usuwalo jebanego TextHajsu przy ladowaniu nowej sceny
        //Abym mógł w SklepHajsWYswietlanko.skrypt odniesc się do TextHajs z tej Sceny.
        //Ale coś za chuj nie działa xD
        //w SKLEPHAJSWYSWIETLANKO.SKRYPT MASZ TEZ KOMENTARZ
    }
    void Update()
    {
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
