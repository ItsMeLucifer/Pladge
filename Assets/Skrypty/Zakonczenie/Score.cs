using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    Text yourscore;
    Text highscore;
    GameObject plat;
    float your = 0;
    float high = 100;
    void Start()
    {
        float temp = PlayerPrefs.GetFloat("playerHighScore", 0f);
        yourscore = GameObject.Find("YOURSCORE").GetComponent<Text>();
        highscore = GameObject.Find("HIGHSCORE").GetComponent<Text>();
        if (GameObject.Find("platforma").GetComponent<SaveLoad>().points > temp)
        {
            PlayerPrefs.SetFloat("playerHighScore", GameObject.Find("platforma").GetComponent<SaveLoad>().points);
        }
        your = GameObject.Find("platforma").GetComponent<SaveLoad>().points;
        high = PlayerPrefs.GetFloat("playerHighScore");
        yourscore.text = your.ToString();
        highscore.text = high.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
