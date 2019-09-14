using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class animacjatlo : MonoBehaviour
{
    public GameObject background;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        background.transform.position += new Vector3(speed, speed / 2, 0);
        if (background.transform.position.y > 0.10)
        {
            speed = Math.Abs(speed)*-1;
        }
        else if(background.transform.position.y < -0.10)
        {
            speed = Math.Abs(speed);

        }
    }
}
