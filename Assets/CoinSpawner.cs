using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public int ile=1;
    public float speed = 2f;
    public Rigidbody2D rb;
    void Start()
    {
        rb.velocity = transform.right * speed;
    }
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.name == "platforma")
        {
            //GameObject.Find("LifeBar").GetComponent<HealthBar>().health -= damage;
            //GameObject.Find("LifeBar").GetComponent<HealthBar>().ZmianaZycia();
            //DODANIE HAJSU
            Destroy(gameObject);
        }
        if (hitInfo.gameObject.tag == "Sciana")
        {
            Destroy(gameObject);
        }
    }
}
