using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackToGame : MonoBehaviour
{
    public void GoBackToGame()
    {
        PlayerPrefs.SetInt("coins", GameObject.Find("TextHajsShop").GetComponent<SklepHajsWyswietlanko>().hajs);
        SceneManager.LoadScene("Poziom1");
    }
}
