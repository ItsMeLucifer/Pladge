using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject menu;
    public int opcja;
    private void Awake()
    {
        DontDestroyOnLoad(menu);
        Screen.SetResolution(500, 840, false);
    }
    // Laduje scene pierwsza z gra
    public void PlayGame()
    {
        opcja = 0;
        SceneManager.LoadScene("Poziom1");
    }
    public void LoadMenu()
    {
        opcja = 1;
        SceneManager.LoadScene("Poziom1");
    }
    // Wyjscie z apki
    public void QuitGame() => Application.Quit();
}
