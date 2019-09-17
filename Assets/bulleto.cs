﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulleto : MonoBehaviour
{
    public float speed = 10f;
    public int damage = 10;
    public GameObject czerw;
    public Rigidbody2D rb;
    void Start()
    {
        rb.velocity = transform.right * speed;
    }
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.name == "platforma")
        {
            GameObject.Find("LifeBar").GetComponent<HealthBar>().health-=damage;
            czerw.transform.localScale = new Vector3(czerw.transform.localScale.x * (GameObject.Find("LifeBar").GetComponent<HealthBar>().health / 100), 0, 0);
        }
        Destroy(gameObject);
    }
}
