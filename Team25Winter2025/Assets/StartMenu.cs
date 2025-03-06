using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    [Header("Scene Links")]
    public string StartingScene;

    public void StartGame()
    {

        SceneManager.LoadScene(StartingScene);

    }

}
