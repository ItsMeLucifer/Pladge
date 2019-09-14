using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class czarnadziura : MonoBehaviour
{
    public GameObject blackhole;
    public float speed=-4;
    public bool powiekszanie=false;
    bool reverse = false;
    void Start()
    {
        blackhole.transform.localScale = new Vector3(0, 0, 0);
        powiekszanie = true;
    }

    void Update()
    {
        blackhole.transform.Rotate(0,0,speed * Time.deltaTime);
        if (powiekszanie == true)
        {
            blackhole.transform.localScale += new Vector3(0.01f, 0.01f, 0);
        }
        if (blackhole.transform.localScale.x >= 0.89f)
        {
            reverse = true;
            powiekszanie = false;
        }
        if (reverse == true && blackhole.transform.localScale.x >= 0.69f)
        {
            blackhole.transform.localScale -= new Vector3(0.03f, 0.03f, 0);
        }
    }
}
