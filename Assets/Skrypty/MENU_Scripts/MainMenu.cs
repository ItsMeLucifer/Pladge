using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Laduje scene pierwsza z gra
    public void PlayGame()
    {
        SceneManager.LoadScene("Poziom1");
    }

    // Wyjscie z apki
    public void QuitGame() => Application.Quit();
}
