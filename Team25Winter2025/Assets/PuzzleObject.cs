using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore;

public class PuzzleObject : MonoBehaviour
{
    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    [Header("Puzzle Settings")]
    public int puzzleID;
    public GameObject manager;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseEnter()
    {
        {
            Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
        }
    }

    private void OnMouseExit()
    {
        Cursor.SetCursor(null, Vector2.zero, cursorMode);
    }

    void OnLeftClick()
    {
        Cursor.SetCursor(null, Vector2.zero, cursorMode);
        var managerScript = manager.GetComponent<OuijaRoomManager>();
        managerScript.PuzzleObjCollected(puzzleID);

    }

    void OnRightClick()
    {

    }
}
