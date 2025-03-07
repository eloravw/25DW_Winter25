using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PaintingManager : MonoBehaviour
{
    [Header("Puzzle Items")]
    public GameObject starClue;
    public GameObject glyphClue;

    [Header("Found Indicators")]
    public GameObject starFound;
    public GameObject glyphFound;

    [Header("Text Clue")]
    public GameObject symbolText;

    private bool foundStar;
    private bool foundGlyph;

    // Start is called before the first frame update
    void Start()
    {

        starFound.SetActive(false);
        glyphFound.SetActive(false);
        symbolText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (foundGlyph && foundStar)
        {
            GameManager.solvedPaintingPuzzle = true;
        }

        if (GameManager.solvedPaintingPuzzle)
        {

            starFound.SetActive(true);
            glyphFound.SetActive(true);
            symbolText.SetActive(true);
        }

    }

    public void PuzzleObjCollected(int puzzleID)
    {

        if (puzzleID == 1)
        {
            starClue.SetActive(false);
            starFound.SetActive(true);
            foundStar = true;
        }

        if (puzzleID == 2)
        {
            glyphClue.SetActive(false);
            glyphFound.SetActive(true);
            foundGlyph = true;
        }

    }
}
