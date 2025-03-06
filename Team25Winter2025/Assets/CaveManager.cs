using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CaveManager : MonoBehaviour
{

    public string targetAnswer;
    public string nextScene;
    public GameObject input;

    // Start is called before the first frame update
    void Start()
    {
        input.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.TranslationClue && GameManager.ouijaCandleCollected && GameManager.ouijaCloakCollected
            && GameManager.ouijaLampCollected && GameManager.solvedCandlePuzzle && GameManager.solvedMusicRoom
            && GameManager.solvedPaintingPuzzle)
        {
            StartRitual();
        }
    }


    public void SubmitAnswer(string enteredWord)
    {
        string answer = enteredWord.Trim();

        if (answer.Equals(targetAnswer, System.StringComparison.OrdinalIgnoreCase))
        {
            SceneManager.LoadScene(nextScene);
        }
    }

    public void StartRitual()
    {
        input.SetActive(true);
    }

}
