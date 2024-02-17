using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        AudioManager.Instance.AudioPlay("InGame");
        SceneManager.LoadScene("MainStage");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
