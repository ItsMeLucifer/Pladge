using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class bulleto : MonoBehaviour
{
    public float speed = 10f;
    public int damage;
    public Rigidbody2D rb;
    void Start()
    {
        rb.velocity = transform.right * speed;
        damage = 5;
    }
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.name == "platforma")
        {
            GameObject.Find("LifeBar").GetComponent<HealthBar>().health-=damage;
            Destroy(gameObject);
        }
        if (hitInfo.gameObject.tag =="Sciana")
        {
            Destroy(gameObject);
        }
    }
}
