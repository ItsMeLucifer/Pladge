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
        hajstxt = GameObject.Find("TextHajsShop").GetComponent<Text>();
        hajs = GameObject.Find("TextHajs").GetComponent<HajsWyswietlanko>().hajs;
        myString = hajs.ToString();
        hajstxt.text = myString;
        //Trzeba pokminić jak dostać się do variable Hajs z obiektu TextHajs ze wcześniejszej sceny
        //Robiłem to na szybko wiec tez sie jakos nie zaglebiałem xD Zostawiam ci to xD
        //w HAJSWYSWIETLANKO.SKRYPT MASZ TEZ KOMENTARZ
    }
    void Update()
    {
        
    }
}
