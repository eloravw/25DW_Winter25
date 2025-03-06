using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicRoomManager : MonoBehaviour
{
    [Header("Clue Items")]
    public GameObject clueE;
    public GameObject clueB;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.clueE)
        {
            clueE.SetActive(false);
        }

        if (GameManager.clueB)
        {
            clueB.SetActive(false);
        }
    }

    public void ClueCollected(int clueID)
    {
        if (clueID == 5)
        {
            GameManager.clueE = true;
        }

        if (clueID == 2)
        {
            GameManager.clueB = true;
        }
    }


}
