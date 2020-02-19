using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class enemy : MonoBehaviour
{
    public GameObject pasekzycia;
    public int zyciepotwora = 200;
    public GameObject monster;
    public float speedo = 0.1f;
    bool pow = true;
    public float rotation;
    public int random;
    public float bulletHz=0.1f;
    public float coinHz = 3f;
    public float perekHz = 10f;
    public GameObject rockbullet;
    public Transform firepoint;
    public Transform coinspawnpoint;
    public Transform perekpoint;
    public GameObject coin;
    public GameObject perekS;
    readonly System.Random rand = new System.Random();
    void Start()
    {
        coinHz = rand.Next(5)+5;
        monster.transform.localScale = new Vector3(0, 0, 0);
        InvokeRepeating("Atak", 2.5f, bulletHz);
        InvokeRepeating("Coins", 2f, coinHz);
        InvokeRepeating("Perek", 3f, perekHz);
        InvokeRepeating("Czas", 0, 1f);
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
        pasekzycia.transform.localScale = new Vector3(zyciepotwora / 1000,pasekzycia.transform.localScale.y,pasekzycia.transform.localScale.z);
    }
    void Atak()
    {
            random = rand.Next(360);
            firepoint.transform.Rotate(0, 0, random);
            Instantiate(rockbullet, firepoint.position, firepoint.rotation);

    }
    void Coins()
    {
        random = rand.Next(360);
        coinspawnpoint.transform.Rotate(0, 0, random);
        Instantiate(coin, coinspawnpoint.position, coinspawnpoint.rotation);

    }
    void Perek()
    {
        random = rand.Next(360);
        perekpoint.transform.Rotate(0, 0, random);
        Instantiate(perekS, perekpoint.position, perekpoint.rotation);
    }
    void Czas()
    {
        zyciepotwora--;
    }
}
