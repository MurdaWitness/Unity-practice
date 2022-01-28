using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class Menu : MonoBehaviour
{
    public Button playBtn;
    public Button exitBtn;

    void Start()
    {
        playBtn.onClick.AddListener(StartGame);
        exitBtn.onClick.AddListener(ExitGame);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void ExitGame()
    {
        Debug.Log("Осуществляю выход");
        Application.Quit();
    }
}
