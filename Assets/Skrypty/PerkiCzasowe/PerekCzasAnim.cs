using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerekCzasAnim : MonoBehaviour
{
    public GameObject redlicznik;
    public float CzasDzalaniaPerka = 0;
    float x = 0;
    void Start()
    {
        redlicznik.transform.localScale = new Vector3(0.0921875f, 0.004f, 1f);
    }
    void Update()
    {
        
    }
    public void StartOdliczania()
    {
        redlicznik.transform.localScale = new Vector3(0.0921875f, 0.004f, 1f);
        x = redlicznik.transform.localScale.x;
        InvokeRepeating("KoniecOdliczania", 0, 1f);
    }
    void KoniecOdliczania()
    {
        redlicznik.transform.localScale -= new Vector3( x / CzasDzalaniaPerka, 0, 0);
        if(redlicznik.transform.localScale.x <= 0f)
        {
            GameObject.Find("platforma").GetComponent<ruch>().KoniecPerekSzybkosc();
            CancelInvoke();
            redlicznik.transform.localScale = new Vector3(0.0921875f, 0.004f, 1f);
            GameObject[] gos = GameObject.FindGameObjectsWithTag("AnimacjaPerekSzybkosciCzas");
           // GameObject.Find("PurpleCoin").SetActive(false);
          //  GameObject.Find("redperek").SetActive(false);

        }
    }
}
