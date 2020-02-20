using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPlayer : MonoBehaviour
{
    public float speed = 3f;
    public Rigidbody2D rb;
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.gameObject.tag == "enemy")
        {
            hitInfo.GetComponent<EnemyHealthBar>().hp += 0.03f;
            Destroy(gameObject);
        }
        if (hitInfo.gameObject.tag == "Sciana")
        {
            Destroy(gameObject);
        }
    }
}