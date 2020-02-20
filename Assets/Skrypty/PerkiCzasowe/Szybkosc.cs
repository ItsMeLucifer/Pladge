using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Szybkosc : MonoBehaviour
{
    public float speed = 10f;
    public int boost = 10;
    public float Czas = 5f;
    public GameObject redperek;
    int random;
    public Rigidbody2D rb;
    readonly System.Random rand = new System.Random();
    void Start()
    {
        rb.velocity = transform.right * speed;
        random = rand.Next(10) - 6;
    }
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.name == "platforma")
        {
            GameObject.Find("platforma").GetComponent<ruch>().CzasDzialaniaPerkaSzybkosc = Czas;
            if (random >= 0)
            {
                GameObject.Find("platforma").GetComponent<ruch>().PerekSzybkosc(-1);
            }
            else
            {
                GameObject.Find("platforma").GetComponent<ruch>().PerekSzybkosc(1);
            }
            //Chce zrobic te jebane dwa obiekty niewidzialne, dopoki nie odpali się perek szybkosc ale chuja z tego wychodzi ja pierdoleeelelellele
           // GameObject.Find("PurpleCoin").SetActive(true);
          //  GameObject.Find("redperek").SetActive(true);
            GameObject.Find("redperek").GetComponent<PerekCzasAnim>().CzasDzalaniaPerka = Czas;
            GameObject.Find("redperek").GetComponent<PerekCzasAnim>().StartOdliczania();
            Destroy(gameObject);
            GameObject.Find("LifeBar").GetComponent<HealthBar>().health = 100;

        }
        if (hitInfo.gameObject.tag == "Sciana")
        {
            Destroy(gameObject);
        }
    }
}
