using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kolor : MonoBehaviour
{
    public Renderer tlo;
    public Renderer plat;
    void Start()
    {

    }
    void Update()
    {
        Vector3 pos = transform.position;
        if (pos.x % 0.5 == 0)
        {
            tlo.material.SetColor("_Color", Random.ColorHSV());
        }
    }
}
