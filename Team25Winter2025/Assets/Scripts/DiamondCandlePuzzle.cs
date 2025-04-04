using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DiamondCandlePuzzle : MonoBehaviour
{
    public CandleManager manager;

    //CANDLES
    public GameObject topCandle;
    public GameObject leftCandle;
    public GameObject bottomCandle;
    public GameObject rightCandle;

    //CANDLE SPRITES
    public Sprite topCandleSprite;
    public Sprite leftCandleSprite;
    public Sprite bottomCandleSprite;
    public Sprite rightCandleSprite;

    public Sprite topCandleSpriteLitOne;
    public Sprite topCandleSpriteLitTwo;
    public Sprite leftCandleSpriteLit;
    public Sprite bottomCandleSpriteLit;
    public Sprite rightCandleSpriteLit;

    //LINES
    public GameObject topLeftLine;
    public GameObject bottomLeftLine;
    public GameObject bottomRightLine;
    public GameObject topRightLine;

    //Path booleans

    bool pathOne;
    bool pathTwo;

    //current sequence position (5 candles total)
    int sequence = 0;

    //holds the next candle in the sequence
    GameObject nextCandle;

    //is this pattern complete?
    bool completeDiamond = false;

    //sounds
    public AudioSource diamondAudio;

    public AudioClip candleBlownOutSE;
    public AudioClip candleLitSE;

    // Start is called before the first frame update
    void Start()
    {
        //hide all lines upon start
        topLeftLine.SetActive(false);
        bottomLeftLine.SetActive(false);
        bottomRightLine.SetActive(false);
        topRightLine.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.solvedCandlePuzzle)
        {
            topLeftLine.SetActive(true);
            bottomLeftLine.SetActive(true);
            bottomRightLine.SetActive(true);
            topRightLine.SetActive(true);
            topCandle.GetComponent<SpriteRenderer>().sprite = topCandleSpriteLitTwo;
            leftCandle.GetComponent<SpriteRenderer>().sprite = leftCandleSpriteLit;
            rightCandle.GetComponent<SpriteRenderer>().sprite = rightCandleSpriteLit;
            bottomCandle.GetComponent<SpriteRenderer>().sprite = bottomCandleSpriteLit;
        }

        diamondAudio.clip = candleLitSE;

        //first candle pressed (top candle)
        if (topCandle.GetComponent<CandleFunctionality>().clicked && sequence == 0)
        {
            topCandle.GetComponent<SpriteRenderer>().sprite = topCandleSpriteLitOne;
            sequence += 1;
            nextCandle = topCandle;
            diamondAudio.Play();
        }
        //wrong press
        if (Input.GetMouseButtonDown(0) && bottomCandle.GetComponent<CandleFunctionality>().clicked && sequence == 1)
        {
            Reset();
        }

        //second candle pressed
        //left candle
        if (leftCandle.GetComponent<CandleFunctionality>().clicked && sequence == 1)
        {
            leftCandle.GetComponent<SpriteRenderer>().sprite = leftCandleSpriteLit;
            sequence += 1;
            pathOne = true;
            pathTwo = false;

            topLeftLine.SetActive(true);

            nextCandle = leftCandle;
            diamondAudio.Play();
        }

        //right candle
        if (rightCandle.GetComponent<CandleFunctionality>().clicked && sequence == 1)
        {
            rightCandle.GetComponent<SpriteRenderer>().sprite = rightCandleSpriteLit;
            sequence += 1;
            pathTwo = true;
            pathOne = false;

            topRightLine.SetActive(true);

            nextCandle = rightCandle;
            diamondAudio.Play();
        }

        //_______________________
        //PATH ONE (left path)
        //_______________________

        if (pathOne)
        {
            if (bottomCandle.GetComponent<CandleFunctionality>().clicked && sequence == 2)
            {
                bottomCandle.GetComponent<SpriteRenderer>().sprite = bottomCandleSpriteLit;
                sequence += 1;

                bottomLeftLine.SetActive(true);

                nextCandle = bottomCandle;
                diamondAudio.Play();
            }

            if (rightCandle.GetComponent<CandleFunctionality>().clicked && sequence == 3)
            {
                rightCandle.GetComponent<SpriteRenderer>().sprite = rightCandleSpriteLit;
                sequence += 1;

                bottomRightLine.SetActive(true);

                nextCandle = rightCandle;
                diamondAudio.Play();
            }

            if (topCandle.GetComponent<CandleFunctionality>().clicked && sequence == 4)
            {
                topCandle.GetComponent<SpriteRenderer>().sprite = topCandleSpriteLitTwo;
                sequence += 1;

                topRightLine.SetActive(true);
                completeDiamond = true;

                nextCandle = topCandle;
                diamondAudio.Play();
            }

        }

        //______________________
        //PATH TWO (right path)
        //______________________

        if (pathTwo)
        {
            if (bottomCandle.GetComponent<CandleFunctionality>().clicked && sequence == 2)
            {
                bottomCandle.GetComponent<SpriteRenderer>().sprite = bottomCandleSpriteLit;
                sequence += 1;

                bottomRightLine.SetActive(true);

                nextCandle = bottomCandle;
                diamondAudio.Play();
            }

            if (leftCandle.GetComponent<CandleFunctionality>().clicked && sequence == 3)
            {
                leftCandle.GetComponent<SpriteRenderer>().sprite = leftCandleSpriteLit;
                sequence += 1;

                bottomLeftLine.SetActive(true);

                nextCandle = leftCandle;
                diamondAudio.Play();
            }

            if (topCandle.GetComponent<CandleFunctionality>().clicked && sequence == 4)
            {
                topCandle.GetComponent<SpriteRenderer>().sprite = topCandleSpriteLitTwo;
                sequence += 1;

                topLeftLine.SetActive(true);
                completeDiamond = true;

                nextCandle = topCandle;
                diamondAudio.Play();
            }

        }
        //wrong press
        if (Input.GetMouseButtonDown(0) && nextCandle.GetComponent<CandleFunctionality>().clicked == false)
        {
            Reset();
        }

        if (completeDiamond == true) manager.CompletedDiamond();

    }

    private void Reset()
    {
        if (!completeDiamond) {
            topLeftLine.SetActive(false);
            bottomLeftLine.SetActive(false);
            bottomRightLine.SetActive(false);
            topRightLine.SetActive(false);

            topCandle.GetComponent<SpriteRenderer>().sprite = topCandleSprite;
            leftCandle.GetComponent<SpriteRenderer>().sprite = leftCandleSprite;
            bottomCandle.GetComponent<SpriteRenderer>().sprite = bottomCandleSprite;
            rightCandle.GetComponent<SpriteRenderer>().sprite = rightCandleSprite;

            sequence = 0;

            pathOne = false;
            pathTwo = false;

            //play candle blown out sound
            diamondAudio.clip = candleBlownOutSE;
            diamondAudio.Play();
        }
    }

}
