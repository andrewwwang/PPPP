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
		GameControlScript.level = 1;
        SceneManager.LoadScene(1);
    }
    public void PlayGame2()
    {
		GameControlScript.level = 2;
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

}
