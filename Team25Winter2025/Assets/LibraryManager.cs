using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LibraryManager : MonoBehaviour
{
    [Header("Clue Items")]
    public GameObject clueW;
    public GameObject clueJ;


    [Header("Puzzle Items")]
    public GameObject puzzleText;
    public GameObject clueObject;

    // Start is called before the first frame update
    void Start()
    {
        puzzleText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (GameManager.TranslationClue)
        {
            puzzleText.SetActive(true);
            clueObject.SetActive(false);
        }

    }

    public void PuzzleObjCollected(int puzzleID)
    {

        if (puzzleID == 1)
        {
            GameManager.TranslationClue = true;
        }

    }

}
