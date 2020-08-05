using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

using UnityEngine.SceneManagement;

public class TestInfo : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    public GameObject continueButton;
    public GameObject exitButton;
    public GameObject goto4GButton;
    public GameObject goto5GButton;
  


    void Start()
    {
        StartCoroutine(Type());
    }

     void Update()
    {
        if (textDisplay.text == sentences[index]) {
            continueButton.SetActive(true);
        }
    }

    IEnumerator Type() {

        yield return new WaitForSeconds(2f);

        foreach (char letter in sentences[index].ToCharArray()) {


            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    
    }
     public void NextSentence()
    {
        continueButton.SetActive(false);
        if (index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());

        }
        else { textDisplay.text = "";
            continueButton.SetActive(false);
            exitButton.SetActive(true);
            Scene currentScene = SceneManager.GetActiveScene();
            string sceneName = currentScene.name;

            if (sceneName == "PlayGame5G")
            {
                goto4GButton.SetActive(true);
            }
            if (sceneName == "PlayGame4.5G")
            {
                goto5GButton.SetActive(true);
            }
            if (sceneName == "PlayRink5G")
            {
                goto4GButton.SetActive(true);
            }
            if (sceneName == "PlayRink4G")
            {
                goto5GButton.SetActive(true);
            }




        }

    }

}
