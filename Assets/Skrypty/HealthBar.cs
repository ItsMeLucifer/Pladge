using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

public class HealthBar : MonoBehaviour
{
    public GameObject bar;
    public Text txt;
    public GameObject czerw;
    public int health;
    public bulleto dmg;
    void Start()
    {
        this.health = 100;
        czerw.transform.localScale = new Vector3(0.5388281f, 0.1413281f, 1);
        txt = GameObject.Find("procentyzycia").GetComponent<Text>();
    }
    void Update()
    {
        if (health <= 0)
        {
            health = 0;
            Die();
        }
        
    }
    void Die()
    {
        Destroy(GameObject.Find("platforma"));
        //IDZ DO SCENY GAMEOVER
    }
    public void ZmianaZycia()
    {
        czerw.transform.localScale = new Vector3(0.5388281f * (health / 100f), 0.1413281f, 1);
        czerw.transform.position -= new Vector3(dmg.damage* 0.008f, 0f, 0f); 
        //^dzieki temu, nawet jak zmienisz zadawany dmg, to czerwony pasek bedzie zawsze w tym samym miejscu xD
        txt.text = health + "%";
    }

    public void BuyHealth()
    {
        this.health += 10;
    }
}
