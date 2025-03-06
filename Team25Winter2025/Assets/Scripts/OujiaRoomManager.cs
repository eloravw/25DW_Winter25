using NodeCanvas.Tasks.Actions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuijaRoomManager : MonoBehaviour
{
    [Header("Ouija Board")]
    public GameObject ouijaBoardItem;
    public GameObject ouijaBoardMenu;

    [Header("Puzzle Items")]
    public GameObject lampP1;

    [Header("Clue Items")]
    public GameObject ClueO;
    public GameObject ClueI;
    public GameObject ClueC;


    private void Start()
    {

        ouijaBoardItem.SetActive(false);

    }

    private void Update()
    {
        if (GameManager.ouijaLampCollected)
        {
            lampP1.SetActive(false);
        }

        if (GameManager.ouijaCandleCollected && GameManager.ouijaCloakCollected && GameManager.ouijaLampCollected)
        {
            PuzzleComplete();
        }

        if (GameManager.clueO)
        {
            ClueO.SetActive(false);
        }

        if (GameManager.clueI)
        {
            ClueI.SetActive(false);
        }

        if (GameManager.clueC)
        {
            ClueC.SetActive(false);
        }


    }

    public void PuzzleObjCollected (int objectID)
    {

        if (objectID == 1)
        {
            GameManager.ouijaLampCollected = true;
        } 


    }

    void PuzzleComplete()
    {
        ouijaBoardItem.SetActive(true);
    }

    public void OuijaToggle()
    {
        if (ouijaBoardMenu.activeInHierarchy)
        {
            ouijaBoardMenu.SetActive(false); 
            ouijaBoardItem.SetActive(true);
        }

        else if (!ouijaBoardMenu.activeInHierarchy)
        {
            ouijaBoardMenu.SetActive(true);
            ouijaBoardItem.SetActive(false);
        }
    }

    public void ClueCollected(int clueID)
    {
        if (clueID == 15)
        {
            GameManager.clueO = true;
        }

        if (clueID == 9)
        {
            GameManager.clueI = true;
        }

        if (clueID == 3)
        {
            GameManager.clueC = true;
        }

    }

}
