using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClueObject : MonoBehaviour
{

    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    [Header("Clue Settings")]
    public string glyph;
    public string translation;
    public int clueID;
    public GameObject manager;

    [Header("Notification Panel")]
    public GameObject notifPanel;

    // Start is called before the first frame update
    void Start()
    {
        notifPanel.SetActive(false);
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
        notifPanel.SetActive(true);

        var notifScript = notifPanel.GetComponent<notifPanelBehaviour>();
        notifScript.GetClue(glyph, translation);

        Cursor.SetCursor(null, Vector2.zero, cursorMode);

        manager.SendMessage("ClueCollected", clueID, SendMessageOptions.DontRequireReceiver);

    }

    void OnRightClick()
    {

    }
}
