using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public string sceneName;

    public void OnLeftClick()
    {
        SceneManager.LoadScene(sceneName);
    }
}
