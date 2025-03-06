using NodeCanvas.Tasks.Actions;
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

    [Header("Clue Items")]
    public GameObject ClueT;
    public GameObject ClueN;

    [Header("Puzzle Items")]
    public GameObject candlePiece;

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

        if (GameManager.clueN)
        {
            ClueN.SetActive(false);
        }

        if (GameManager.clueT)
        {
            ClueT.SetActive(false);
        }

        if (GameManager.ouijaCandleCollected)
        {
            candlePiece.SetActive(false);
        }

    }

    public void ClueCollected(int clueID)
    {
        if (clueID == 14)
        {
            GameManager.clueN = true;
        }

        if (clueID == 20)
        {
            GameManager.clueB = true;
        }
    }

    public void PuzzleObjCollected (int puzzleID)
    {
        if (puzzleID == 2)
        {
            GameManager.ouijaCandleCollected = true;
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
