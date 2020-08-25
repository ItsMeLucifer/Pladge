using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CzasGry : MonoBehaviour
{
    Text txt;
    public int czas = 60;
    string myString;
    public GameObject plansza;
    // Start is called before the first frame update
    void Start()
    {
        czas = 60;
        plansza = GameObject.Find("CzarnaPlansza");
        txt = GameObject.Find("TextCzasGry").GetComponent<Text>();
        plansza.SetActive(false);
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
            //SceneManager.LoadScene("MENU");
            //poziom1done = true;
            Time.timeScale = 0f;
            Destroy(GameObject.Find("TextCzasGry"));
            plansza.SetActive(true);
        }
    }
    void CzasGryy()
    {
        czas--;
    }
}
