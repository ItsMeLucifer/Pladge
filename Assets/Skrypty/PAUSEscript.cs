using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PAUSEscript : MonoBehaviour
{
    int coins;
    public void GoBackToMenu()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1f;
    }
    public void Shop()
    {
        coins = GameObject.Find("TextHajs").GetComponent<HajsWyswietlanko>().hajs;
        PlayerPrefs.SetInt("coins", coins);
        SceneManager.LoadScene("Shop");
        //Time.timeScale = 0f;
        GameObject.Find("platforma").GetComponent<PauseScript>().Pause(true);
    }
}
