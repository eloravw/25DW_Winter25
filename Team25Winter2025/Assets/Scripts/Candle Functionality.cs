using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleFunctionality : MonoBehaviour
{
    //whether the candle has been clicked
    public bool clicked = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        clicked = true;
    }

    private void OnMouseUp()
    {
        clicked = false;
    }
}
