using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkullObject : MonoBehaviour
{
    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    public float offset;

    public float shakeSpeed = 50;
    public float shakeAmount = 0.02f;
    private float shakeTimer = 5;
    private float shakeDuration = 0.2f;

    private Vector3 startPosition;

    private void Start()
    {
        startPosition = transform.position;
    }
    private void OnMouseEnter()
    {
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    }

    private void OnMouseExit()
    {
        Cursor.SetCursor(null, Vector2.zero, cursorMode);
    }

    private void Update()
    {
        shakeTimer = shakeTimer + 1 * Time.deltaTime;
        if (shakeTimer <= shakeDuration) transform.position = new Vector3(Mathf.Sin(Time.time * shakeSpeed) * shakeAmount + offset, transform.position.y, transform.position.z);
        else transform.position = startPosition;
    }

    private void Shake()
    {
        shakeTimer = 0;

        AudioSource audio = GetComponent<AudioSource>();

        audio.Play();
    }
}
