using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main : MonoBehaviour {
    public void Awake()
    {
        Cursor.visible = true;
    }
    public void PlayGame()
    {
		PlayerPrefs.SetInt ("Level", 1);
		PlayerPrefs.SetInt ("Health", 2);
        SceneManager.LoadScene(1);
    }
    public void PlayGame2()
    {
		PlayerPrefs.SetInt ("Level", 2);
		PlayerPrefs.SetInt ("Health", 2);
        SceneManager.LoadScene(2);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void HowToPlay()
    {
        SceneManager.LoadScene(5);
    }
    public void Story()
    {
        SceneManager.LoadScene(6);
    }

}
