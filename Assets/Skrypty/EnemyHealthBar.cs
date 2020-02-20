using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyHealthBar : MonoBehaviour
{
    public Transform bar;

    public GameObject plat;

    public float hp = -1.01f;

    private void Start()
    {
        InvokeRepeating("SetSize", 0, 2f);
    }
    
    private void Update()
    {
        if (hp >= 0f)
        {
            plat.GetComponent<SaveLoad>().points += 1000f;
            plat.GetComponent<SaveLoad>().points += GameObject.Find("LifeBar").GetComponent<HealthBar>().health*300;
            plat.GetComponent<SaveLoad>().Dodaj();
            plat.GetComponent<SaveLoad>().Save();
            SceneManager.LoadScene("Zakonczenie");
        }
        bar.localScale = new Vector3(hp, 1f);
    }
    public void SetSize()
    {
        hp += 0.01f;
        bar.localScale = new Vector3(hp, 1f);
    }
}
