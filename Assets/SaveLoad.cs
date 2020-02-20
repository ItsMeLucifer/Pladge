using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveLoad : MonoBehaviour
{
    public GameObject platforma;
    public GameObject enemyHealth;
    public Text coins;
    public GameObject lifebar;
    public GameObject CzasGry;
    private float zycie;
    private int monety;
    private float zycieprzeciwnika;
    private Vector3 playerPosition;
    private Vector3 playerRotation;
    private int czasgiery;
    public float points;
    void Start()
    {
        InvokeRepeating("Save", 0, 10f);
        InvokeRepeating("Points", 0, 1f);
        if (PlayerPrefs.GetFloat("enemyHealth") < -0.5f)
        {
            Load();
        }
        DontDestroyOnLoad(gameObject);
    }
    
    private void Points()
    {
        points++;
    }
    public void Dodaj()
    {
        points += monety*100;
    }
    public void Save()
    {
        playerPosition = platforma.transform.position;
        playerRotation = platforma.transform.rotation.eulerAngles;
        zycieprzeciwnika = enemyHealth.GetComponent<EnemyHealthBar>().hp;
        monety = coins.GetComponent<HajsWyswietlanko>().hajs;
        zycie = lifebar.GetComponent<HealthBar>().health;
        if (GameObject.Find("TextCzasGry")){ 
            czasgiery = CzasGry.GetComponent<CzasGry>().czas;
            PlayerPrefs.SetInt("gameTime", czasgiery);
        }
        else
        {
            czasgiery = -1;
            PlayerPrefs.SetInt("gameTime", czasgiery);
        }
        PlayerPrefs.SetFloat("playerPositionX", playerPosition.x);
        PlayerPrefs.SetFloat("playerPositionY", playerPosition.y);
        PlayerPrefs.SetFloat("playerRotationZ", playerRotation.z);
        PlayerPrefs.SetFloat("enemyHealth", zycieprzeciwnika);
        PlayerPrefs.SetInt("playerCoins", monety);
        PlayerPrefs.SetFloat("playerLife", zycie);
        PlayerPrefs.SetFloat("playerPoints", points);
        
    }
    private void Load()
    {
        Vector3 playerposition = new Vector3(PlayerPrefs.GetFloat("playerPositionX"),PlayerPrefs.GetFloat("playerPositionY"),0);
        platforma.transform.position = playerposition;
        platforma.transform.eulerAngles = new Vector3(0,0,(int)PlayerPrefs.GetFloat("playerRotationZ"));
        platforma.transform.Rotate(0, 0, -90);
        enemyHealth.GetComponent<EnemyHealthBar>().hp = PlayerPrefs.GetFloat("enemyHealth");
        coins.GetComponent<HajsWyswietlanko>().hajs = PlayerPrefs.GetInt("playerCoins");
        lifebar.GetComponent<HealthBar>().health = PlayerPrefs.GetFloat("playerLife");
        points = PlayerPrefs.GetFloat("playerPoints");
        if (PlayerPrefs.GetInt("gameTime") > 0)
        {
            CzasGry.GetComponent<CzasGry>().czas = PlayerPrefs.GetInt("gameTime");
        }
        else
        {
            GameObject.Find("TextCzasGry").SetActive(false);
        }
    }
}
