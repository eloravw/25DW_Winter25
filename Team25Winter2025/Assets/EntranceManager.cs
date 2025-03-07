using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntranceManager : MonoBehaviour
{
    [Header("Clue Items")]
    public GameObject ClueU;
    public GameObject ClueG;

    [Header("Puzzle Items")]
    public GameObject cloak;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.ouijaCloakCollected)
        {
            cloak.SetActive(false);
        }

        if (GameManager.clueG)
        {
            ClueG.SetActive(false);
        }

        if (GameManager.clueU)
        {
            ClueU.SetActive(false);
        }
    }

    public void PuzzleObjCollected(int puzzleID)
    {

        if (puzzleID == 1)
        {
            GameManager.ouijaCloakCollected = true;
        }

    }

    public void ClueCollected(int clueID)
    {
        if (clueID == 21)
        {
            GameManager.clueU = true;
        }

        if (clueID == 7)
        {
            GameManager.clueG = true;
        }
    }

}
