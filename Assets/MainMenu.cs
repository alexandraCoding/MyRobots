using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public GameObject exitButton;
    public void Play() {

        SceneManager.LoadScene("Options");
        }

    public void PlayGame()
    {

        SceneManager.LoadScene("PlayGame");
    }

    public void GoToSettingsMenu() {
        SceneManager.LoadScene("SettingsMenu");
    }

    public void GoToMainMenu() {
        SceneManager.LoadScene("MainMenu");

    }

    public void GoTo5G()
    {
        SceneManager.LoadScene("PlayGame5G");

    }

    public void GoTo4G()
    {
        SceneManager.LoadScene("PlayGame4.5G");

    }
    /// <AnotherRinkIce4gand5g
    public void GoTo5rinkG()
    {
        SceneManager.LoadScene("PlayRink5G");

    }

    public void GoTo4rinkG()
    {
        SceneManager.LoadScene("PlayRink4G");

    }
    /// </summary>



    public void QuitGame() {

        Application.Quit();
    }

}
