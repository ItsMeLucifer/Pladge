using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CzasGry : MonoBehaviour
{
    Text txt;
    bool poziom1done = false;
    int czas = 60;
    string myString;
    // Start is called before the first frame update
    void Start()
    {
        txt = GameObject.Find("TextCzasGry").GetComponent<Text>();
        InvokeRepeating("CzasGryy", 0, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        myString = czas.ToString();
        myString += " s";
        txt.text = myString;
        if (czas <= 0)
        {
            SceneManager.LoadScene("MENU");
            poziom1done = true;
        }
    }
    void CzasGryy()
    {
        czas--;
    }
}
