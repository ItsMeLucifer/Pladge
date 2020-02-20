using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chap2Menu : MonoBehaviour
{
    public void Chap2Start()
    {
        GameObject.Find("CzarnaPlansza").SetActive(false);
        GameObject.Find("platforma").GetComponent<StrzelaniePlayer>().StrzelanieStart();
        GameObject.Find("LifeBar").GetComponent<HealthBar>().health = 100;
        Time.timeScale = 1f;
    }
}
