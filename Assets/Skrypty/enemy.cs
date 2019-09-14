using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class enemy : MonoBehaviour
{
    public GameObject monster;
    public float speedo = 0.1f;
    bool pow=true;
    public float rotation;
    
    void Start()
    {
        monster.transform.localScale = new Vector3(0, 0, 0);
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
            speedo *=-1;
        }
        else if (monster.transform.rotation.eulerAngles.z >= 6 && monster.transform.rotation.eulerAngles.z < 100)
        {
            speedo*=-1;
        }
        if (GameObject.Find("blackhole").GetComponent<czarnadziura>().powiekszanie == false && pow==true)
        {
            monster.transform.localScale += new Vector3(0.02f, 0.02f, 0);
        }
        if (monster.transform.localScale.x >= 0.50f)
        {
            pow = false;
        }
    }
}
