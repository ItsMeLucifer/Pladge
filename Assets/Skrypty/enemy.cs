using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class enemy : MonoBehaviour
{
    public GameObject monster;
    public float speedo = 0.1f;
    bool pow = true;
    public float rotation;
    int zakres=0;
    public int random;

    void Start()
    {
        monster.transform.localScale = new Vector3(0, 0, 0);
        InvokeRepeating("Atak", 2.0f, 0.5f);
    }

    void Update()
    {
        rotation = monster.transform.rotation.eulerAngles.z;
        if (GameObject.Find("blackhole").GetComponent<czarnadziura>().powiekszanie == false)
        {
            monster.transform.Rotate(0, 0, speedo * Time.deltaTime);
        }
        if (monster.transform.rotation.eulerAngles.z <= 354 && monster.transform.rotation.eulerAngles.z > 100)
        {
            speedo *= -1;
        }
        else if (monster.transform.rotation.eulerAngles.z >= 6 && monster.transform.rotation.eulerAngles.z < 100)
        {
            speedo *= -1;
        }
        if (GameObject.Find("blackhole").GetComponent<czarnadziura>().powiekszanie == false && pow == true)
        {
            monster.transform.localScale += new Vector3(0.02f, 0.02f, 0);
        }
        if (monster.transform.localScale.x >= 0.50f)
        {
            pow = false;
        }
        //STRZALY SKALNE
        
        
        
    }
    public GameObject rockbullet;
    public Transform firepoint;
    void Atak()
    {
        //NO KURWA MAC NIE WIEM JAK ZROBIC ABY KURWA RANDOMOWO DO CHUJA WYBIERALO KĄT WYSTRZAŁU, NO JEBNE ZARAZ
        System.Random rand = new System.Random();
        random = rand.Next(360);
        Quaternion qua = new Quaternion(0,0, random,0);
        Instantiate(rockbullet, firepoint.position, qua);//KURWA TUTAJ< 3 ZMIENNA W NAWIASIE MUSI BYC JAKIMS JEBANYM QUATERNIONEM NO JA PIERDOLE ZAJEBIEKOMUS ZARAZ, JAK SIE ZTEGO GOWNA KORZYSTA
        //CHCE TYLKO ABY ZMIENNA RANDOM BYLA KURWA W ROTACJI Z, TAK KURWA TRUDNO?
    }
}
