using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrzelaniePlayer : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bulletPrefab;
    public void StrzelanieStart()
    {
        InvokeRepeating("Strzelanie",0,3f);
    }
    private void Strzelanie()
    {
        Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
    }
}

