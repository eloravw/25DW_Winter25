using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroyOnLoad : MonoBehaviour
{

    private Scene scene;

    // Start is called before the first frame update
    void Start()
    {

        scene = SceneManager.GetActiveScene();

        if (scene.name != "Summon")
        {
            DontDestroyOnLoad(this.gameObject);
        }

        else
        {
            Destroy(this.gameObject);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
