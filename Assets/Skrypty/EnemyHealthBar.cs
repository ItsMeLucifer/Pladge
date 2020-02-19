using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyHealthBar : MonoBehaviour
{
    private Transform bar;

    private float hp = -.99f;

    private void Start()
    {
        bar = transform.Find("Bar");
        //bar.localScale = new Vector3(-.4f, 1f);
        InvokeRepeating("SetSize", 0, 2f);
    }
    
    private void Update()
    {
        if (hp >= 0f)
        {
            SceneManager.LoadScene("Zakonczenie");
        }
    }
    public void SetSize()
    {
        hp += 0.01f;
        bar.localScale = new Vector3(hp, 1f);
    }
}
