using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class SpikesCandlePuzzle : MonoBehaviour
{
    public CandleManager manager;

    //CANDLES (candles are ordered from left to right, top to bottom (ie. candles[0] is the top leftmost candle, candle[1] is the bottom leftmost candle)
    public List<GameObject> candles;

    //CANDLE SPRITES
    public Sprite candle1Unlit;
    public Sprite candle2Unlit;
    public Sprite doubleCandleUnlit;

    public Sprite candle1Lit;
    public Sprite candle2Lit;
    public Sprite doubleCandleLitOne;
    public Sprite doubleCandleLitTwo;

    //LINES (ordered the same as candles - left to right, top to bottom)
    public List<GameObject> lines;

    //Path booleans

    bool pathOne;
    bool pathTwo;

    //current sequence position (5 candles total)
    int sequence = 0;

    //holds the next candle in the sequence
    GameObject nextCandle;

    //is this pattern complete?
    bool completeSpikes = false;

    //sounds
    public AudioSource spikesAudio;

    public AudioClip candleBlownOutSE;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < lines.Count; i++)
        {
            lines[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (candles[0].GetComponent<CandleFunctionality>().clicked && sequence == 0)
        {
            candles[0].GetComponent<SpriteRenderer>().sprite = candle2Lit;
            sequence += 1;
            pathOne = true;
            pathTwo = false;

            nextCandle = candles[0];
        }

        if (candles[6].GetComponent<CandleFunctionality>().clicked && sequence == 0)
        {
            candles[6].GetComponent<SpriteRenderer>().sprite = candle2Lit;
            sequence += 1;
            pathTwo = true;
            pathOne = false;
        }

        //_________________________
        //PATH ONE (start left)
        //_________________________

        if (pathOne)
        {
            if (candles[2].GetComponent<CandleFunctionality>().clicked && sequence == 1)
            {
                candles[2].GetComponent<SpriteRenderer>().sprite = doubleCandleLitOne;
                sequence += 1;

                lines[0].SetActive(true);

                nextCandle = candles[2];
            }

            if (candles[1].GetComponent<CandleFunctionality>().clicked && sequence == 2)
            {
                candles[1].GetComponent<SpriteRenderer>().sprite = candle1Lit;
                sequence += 1;

                lines[1].SetActive(true);

                nextCandle = candles[1];
            }

            if (candles[2].GetComponent<CandleFunctionality>().clicked && sequence == 3)
            {
                candles[2].GetComponent<SpriteRenderer>().sprite = doubleCandleLitTwo;
                sequence += 1;

                nextCandle = candles[2];
            }

            if (candles[3].GetComponent<CandleFunctionality>().clicked && sequence == 4)
            {
                candles[3].GetComponent<SpriteRenderer>().sprite = doubleCandleLitOne;
                sequence += 1;

                lines[2].SetActive(true);

                nextCandle = candles[3];
            }

            if (candles[4].GetComponent<CandleFunctionality>().clicked && sequence == 5)
            {
                candles[4].GetComponent<SpriteRenderer>().sprite = candle1Lit;
                sequence += 1;

                lines[3].SetActive(true);

                nextCandle = candles[4];
            }

            if (candles[3].GetComponent<CandleFunctionality>().clicked && sequence == 6)
            {
                candles[3].GetComponent<SpriteRenderer>().sprite = doubleCandleLitTwo;
                sequence += 1;

                nextCandle = candles[3];
            }

            if (candles[5].GetComponent<CandleFunctionality>().clicked && sequence == 7)
            {
                candles[5].GetComponent<SpriteRenderer>().sprite = doubleCandleLitOne;
                sequence += 1;

                lines[4].SetActive(true);

                nextCandle = candles[5];
            }

            if (candles[7].GetComponent<CandleFunctionality>().clicked && sequence == 8)
            {
                candles[7].GetComponent<SpriteRenderer>().sprite = candle1Lit;
                sequence += 1;

                lines[6].SetActive(true);

                nextCandle = candles[7];
            }

            if (candles[5].GetComponent<CandleFunctionality>().clicked && sequence == 9)
            {
                candles[5].GetComponent<SpriteRenderer>().sprite = doubleCandleLitTwo;
                sequence += 1;

                nextCandle = candles[5];
            }

            if (candles[6].GetComponent<CandleFunctionality>().clicked && sequence == 10)
            {
                candles[6].GetComponent<SpriteRenderer>().sprite = candle2Lit;
                sequence += 1;

                lines[5].SetActive(true);

                nextCandle = candles[6];

                completeSpikes = true;
            }

        }

        //_________________________
        //PATH TWO (start right)
        //_________________________
        if (pathTwo)
        {
            if (candles[5].GetComponent<CandleFunctionality>().clicked && sequence == 1)
            {
                candles[5].GetComponent<SpriteRenderer>().sprite = doubleCandleLitOne;
                sequence += 1;

                lines[5].SetActive(true);

                nextCandle = candles[5];
            }

            if (candles[7].GetComponent<CandleFunctionality>().clicked && sequence == 2)
            {
                candles[7].GetComponent<SpriteRenderer>().sprite = candle1Lit;
                sequence += 1;

                lines[6].SetActive(true);

                nextCandle = candles[7];
            }

            if (candles[5].GetComponent<CandleFunctionality>().clicked && sequence == 3)
            {
                candles[5].GetComponent<SpriteRenderer>().sprite = doubleCandleLitTwo;
                sequence += 1;

                nextCandle = candles[5];
            }

            if (candles[3].GetComponent<CandleFunctionality>().clicked && sequence == 4)
            {
                candles[3].GetComponent<SpriteRenderer>().sprite = doubleCandleLitOne;
                sequence += 1;

                lines[4].SetActive(true);

                nextCandle = candles[3];
            }

            if (candles[4].GetComponent<CandleFunctionality>().clicked && sequence == 5)
            {
                candles[4].GetComponent<SpriteRenderer>().sprite = candle1Lit;
                sequence += 1;

                lines[3].SetActive(true);

                nextCandle = candles[4];
            }

            if (candles[3].GetComponent<CandleFunctionality>().clicked && sequence == 6)
            {
                candles[3].GetComponent<SpriteRenderer>().sprite = doubleCandleLitTwo;
                sequence += 1;

                nextCandle = candles[3];
            }

            if (candles[2].GetComponent<CandleFunctionality>().clicked && sequence == 7)
            {
                candles[2].GetComponent<SpriteRenderer>().sprite = doubleCandleLitOne;
                sequence += 1;

                lines[2].SetActive(true);

                nextCandle = candles[2];
            }

            if (candles[1].GetComponent<CandleFunctionality>().clicked && sequence == 8)
            {
                candles[1].GetComponent<SpriteRenderer>().sprite = candle1Lit;
                sequence += 1;

                lines[1].SetActive(true);

                nextCandle = candles[1];
            }

            if (candles[2].GetComponent<CandleFunctionality>().clicked && sequence == 9)
            {
                candles[2].GetComponent<SpriteRenderer>().sprite = doubleCandleLitTwo;
                sequence += 1;

                nextCandle = candles[2];
            }

            if (candles[0].GetComponent<CandleFunctionality>().clicked && sequence == 10)
            {
                candles[0].GetComponent<SpriteRenderer>().sprite = candle2Lit;
                sequence += 1;

                lines[0].SetActive(true);

                nextCandle = candles[0];

                completeSpikes = true;
            }

        }

        //wrong press
        if (Input.GetMouseButtonDown(0) && nextCandle.GetComponent<CandleFunctionality>().clicked == false)
        {
            Reset();
        }

        if (completeSpikes == true) manager.CompletedSpikes();

    }

    private void Reset()
    {
        if (!completeSpikes)
        {
            for (int i = 0; i < lines.Count; i++)
            {
                lines[i].SetActive(false);
            }

            candles[0].GetComponent<SpriteRenderer>().sprite = candle2Unlit;
            candles[1].GetComponent<SpriteRenderer>().sprite = candle1Unlit;
            candles[2].GetComponent<SpriteRenderer>().sprite = doubleCandleUnlit;
            candles[3].GetComponent<SpriteRenderer>().sprite = doubleCandleUnlit;
            candles[4].GetComponent<SpriteRenderer>().sprite = candle1Unlit;
            candles[5].GetComponent<SpriteRenderer>().sprite = doubleCandleUnlit;
            candles[6].GetComponent<SpriteRenderer>().sprite = candle2Unlit;
            candles[7].GetComponent<SpriteRenderer>().sprite = candle1Unlit;

            pathOne = false;
            pathTwo = false;

            sequence = 0;

            //play candle blown out sound
            spikesAudio.clip = candleBlownOutSE;
            spikesAudio.Play();
        }
    }
}
