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
    public GameObject candleP2;
    public GameObject cloakP3;


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

        if (GameManager.ouijaCandleCollected)
        {
            candleP2.SetActive(false);
        }

        if (GameManager.ouijaCloakCollected)
        {
            cloakP3.SetActive(false);
        }

        if (GameManager.ouijaCandleCollected && GameManager.ouijaCloakCollected && GameManager.ouijaLampCollected)
        {
            PuzzleComplete();
        }

    }

    public void PuzzleObjCollected (int objectID)
    {

        if (objectID == 1)
        {
            GameManager.ouijaLampCollected = true;
        }

        if (objectID == 2)
        {
            GameManager.ouijaCandleCollected = true;
        }

        if (objectID == 3)
        {
            GameManager.ouijaCloakCollected = true;
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
}
