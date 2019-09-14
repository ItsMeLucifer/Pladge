﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ruch : MonoBehaviour
{
    public float speed = 0.05f;
    public GameObject plat;
    public bool prawo = true;
    public bool poziomy = false;
    public static ruch instace;
    void Start()
    {
        poziomy = true;
        prawo = true;
    }
    void Update()
    {

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            if (prawo == true)
            {
                prawo = false;
            }
            else
            {
                prawo = true;
            }
            speed *= -1;
        }
        if (Input.GetMouseButtonDown(0))
        {
            if (prawo == true)
            {
                prawo = false;
            }
            else
            {
                prawo = true;
            }
            speed *= -1;
        }
        if (poziomy == true)
        {
            plat.transform.position += new Vector3(speed, 0, 0);
        }
        else
        {
            plat.transform.position += new Vector3(0, speed, 0);
        }
        if (prawo == true) //RUCH W PRAWO
        {
            //Lewa Ściana, Ruch w Dół [LEWY DOLNY RÓG]
            if (plat.transform.position.x < 0 && plat.transform.position.y < -4.35f && poziomy == false)
            {
                plat.transform.Rotate(0, 0, 90, Space.Self);
                plat.transform.position = new Vector3(-2.170f, -4.885f, 0f);
                poziomy = true;
                speed = Math.Abs(speed);
            }
            //Dolna Platforma, Ruch w Prawo [PRAWY DOLNY RÓG] 
            if (plat.transform.position.x > 2.18f && plat.transform.position.y < 0 && poziomy == true)
            {
                plat.transform.Rotate(0, 0, -90, Space.Self);
                plat.transform.position = new Vector3(2.691f, -4.3f, 0f);
                poziomy = false;
                speed = Math.Abs(speed);
            }
            //Prawa Ściana, Ruch w Górę [PRAWY GÓRNY RÓG]
            if (plat.transform.position.y > 4.38f && plat.transform.position.x > 0 && poziomy == false)
            {
                plat.transform.Rotate(0, 0, 90, Space.Self);
                plat.transform.position = new Vector3(2.173f, 4.882f, 0f);
                poziomy = true;
                speed = Math.Abs(speed) * -1;
            }
            //Górna Platforma, Ruch w Lewo [LEWY GÓRNY RÓG]
            if (plat.transform.position.x < -2.17f && plat.transform.position.y > 0 && poziomy == true)
            {
                plat.transform.Rotate(0, 0, -90, Space.Self);
                plat.transform.position = new Vector3(-2.701f, 4.362f, 0f);
                poziomy = false;
                speed = Math.Abs(speed) * -1;
            }
        }
        else if (prawo == false) //RUCH W LEWO
        {
            //Dolna Platforma, Ruch w Lewo [LEWY DOLNY RÓG]
            if (plat.transform.position.x < -2.17f && plat.transform.position.y < 0 && poziomy == true)
            {
                plat.transform.Rotate(0, 0, -90, Space.Self);
                plat.transform.position = new Vector3(-2.691f, -4.357f, 0f);
                poziomy = false;
                speed = Math.Abs(speed);
            }
            //Lewa Ściana, Ruch w Górę [LEWY GÓRNY RÓG]
            if (plat.transform.position.x < 0 && plat.transform.position.y > 4.37f && poziomy == false)
            {
                plat.transform.Rotate(0, 0, 90, Space.Self);
                plat.transform.position = new Vector3(-2.173f, 4.882f, 0f);
                poziomy = true;
                speed = Math.Abs(speed);
            }
            //Górna Platforma, Ruch w Prawo [PRAWY GÓRNY RÓG]
            if (plat.transform.position.x > 2.19 && plat.transform.position.y > 0 && poziomy == true)
            {
                plat.transform.Rotate(0, 0, -90, Space.Self);
                plat.transform.position = new Vector3(2.701f, 4.362f, 0f);
                poziomy = false;
                speed = Math.Abs(speed) * -1;
            }
            //Prawa Ściana, Ruch w Dół [PRAWY DOLNY RÓG]
            if (plat.transform.position.x > 0 && plat.transform.position.y < -4.37f && poziomy == false)
            {
                plat.transform.Rotate(0, 0, 90, Space.Self);
                plat.transform.position = new Vector3(2.177f, -4.885f, 0f);
                poziomy = true;
                speed = Math.Abs(speed) * -1;
            }
        }
    }
}
