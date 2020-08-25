using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class High : MonoBehaviour
{
    Text highscore;
    public GameObject HIGHSCORE;
    public GameObject YOURSCORE;
    float your2 = 0;
    float high = 100;
    string score;
    float temp;
    void Start()
    {
        temp = PlayerPrefs.GetFloat("playerHighScore", 0f);
        highscore = HIGHSCORE.GetComponent<Text>();
        your2 = YOURSCORE.GetComponent<Your>().your1;
        if (your2 > temp)
        {
            PlayerPrefs.SetFloat("playerHighScore", your2);
        }
        high = PlayerPrefs.GetFloat("playerHighScore");
        score = high.ToString();
        highscore.text = score;
    }
}
