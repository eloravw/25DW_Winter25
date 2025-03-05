using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DiamondCandlePuzzle : MonoBehaviour
{
    //CANDLES
    public GameObject topCandle;
    public GameObject leftCandle;
    public GameObject bottomCandle;
    public GameObject rightCandle;

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
        //first candle pressed (top candle)
        if (topCandle.GetComponent<CandleFunctionality>().clicked && sequence == 0)
        {
            topCandle.GetComponent<SpriteRenderer>().color = Color.magenta;
            sequence += 1;
        }

        //second candle pressed
        //left candle
        if (leftCandle.GetComponent<CandleFunctionality>().clicked && sequence == 1)
        {
            leftCandle.GetComponent<SpriteRenderer>().color = Color.red;
            sequence += 1;
            pathOne = true;
            pathTwo = false;

            topLeftLine.SetActive(true);
        }

        //right candle
        if (rightCandle.GetComponent<CandleFunctionality>().clicked && sequence == 1)
        {
            rightCandle.GetComponent<SpriteRenderer>().color = Color.red;
            sequence += 1;
            pathTwo = true;
            pathOne = false;

            topRightLine.SetActive(true);
        }

        //_______________________
        //PATH ONE (left path)
        //_______________________

        if (pathOne)
        {
            if (bottomCandle.GetComponent<CandleFunctionality>().clicked && sequence == 2)
            {
                bottomCandle.GetComponent<SpriteRenderer>().color = Color.red;
                sequence += 1;

                bottomLeftLine.SetActive(true);
            }

            if (rightCandle.GetComponent<CandleFunctionality>().clicked && sequence == 3)
            {
                rightCandle.GetComponent<SpriteRenderer>().color = Color.red;
                sequence += 1;

                bottomRightLine.SetActive(true);
            }

            if (topCandle.GetComponent<CandleFunctionality>().clicked && sequence == 4)
            {
                topCandle.GetComponent<SpriteRenderer>().color = Color.red;
                sequence += 1;

                topRightLine.SetActive(true);
            }
        }

        //______________________
        //PATH TWO (right path)
        //______________________

        if (pathTwo)
        {
            if (bottomCandle.GetComponent<CandleFunctionality>().clicked && sequence == 2)
            {
                bottomCandle.GetComponent<SpriteRenderer>().color = Color.red;
                sequence += 1;

                bottomRightLine.SetActive(true);
            }

            if (leftCandle.GetComponent<CandleFunctionality>().clicked && sequence == 3)
            {
                leftCandle.GetComponent<SpriteRenderer>().color = Color.red;
                sequence += 1;

                bottomLeftLine.SetActive(true);
            }

            if (topCandle.GetComponent<CandleFunctionality>().clicked && sequence == 4)
            {
                topCandle.GetComponent<SpriteRenderer>().color = Color.red;
                sequence += 1;

                topLeftLine.SetActive(true);
            }
        }

    }

}
