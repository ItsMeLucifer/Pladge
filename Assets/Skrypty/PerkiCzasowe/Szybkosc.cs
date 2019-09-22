using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Szybkosc : MonoBehaviour
{
    public float speed = 10f;
    public int boost = 10;
    public float Czas = 5f;
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
            //POKAZANIE SIE LICZNIKA NA SRODKU EKRANU Z DLUGOSCIA DZIALANIA PERKA SZYBKOSCI.
            //STWORZYC SKRYPT DLA TEGO LICZNIKA, W KTORYM ( GDY CZAS SIE SKONCZY ) ODPALI SIE FUNKCJA, KTORA PRZYWROCI PODSTAWOWA PREDKOSC PLATFORMIE
            //LICZNIK BEDZIE UNIWERSALNY, CO SEKUNDE BEDZIE ZMNIEJSZAL SWOJE SKALOWANIE O 1/N, GDZIE 'N' TO CZAS PODANY WYŻEJ, KTORY OKRESLA DLUGOSC DZIALANIA PERKA
            Destroy(gameObject);
        }
        if (hitInfo.gameObject.tag == "Sciana")
        {
            Destroy(gameObject);
        }
    }
}
