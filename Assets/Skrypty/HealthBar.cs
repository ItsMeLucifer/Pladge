using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public GameObject bar;
    public GameObject text;
    public GameObject czerw;
    public int health=100;
    void Start()
    {
        
    }
    void Update()
    {
        if (health <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        Destroy(GameObject.Find("platforma"));
        //IDZ DO SCENY GAMEOVER
    }
}
