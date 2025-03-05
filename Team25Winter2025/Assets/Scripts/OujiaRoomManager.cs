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

    private bool lampCollected = false;
    private bool candleCollected = false;
    private bool cloakCollected = false;

    private void Start()
    {

        ouijaBoardItem.SetActive(false);

    }

    private void Update()
    {
       if (lampCollected && candleCollected && cloakCollected)
        {
            PuzzleComplete();
        }

    }

    public void PuzzleObjCollected (int objectID)
    {

        if (objectID == 1)
        {
            lampCollected = true;
            lampP1.SetActive(false);
        }

        if (objectID == 2)
        {
            candleCollected = true;
            candleP2.SetActive(false);
        }

        if (objectID == 3)
        {
            cloakCollected = true;
            cloakP3.SetActive(false);
        }

    }

    void PuzzleComplete()
    {
        Debug.Log("Puzzle Complete");

        lampCollected = false;
        cloakCollected = false;
        candleCollected = false;

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
