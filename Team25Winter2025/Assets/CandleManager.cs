using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CandleManager : MonoBehaviour
{

    public TextMeshProUGUI runeText;

    private bool diamond = false;
    private bool spikes = false;

    void Update()
    {
        if (diamond && spikes)
        {
            RevealRune();
        }
    }

    public void CompletedDiamond()
    {
        diamond = true;
    }

    public void CompletedSpikes()
    {
        spikes = true;
    }

    void RevealRune()
    {
        runeText.alpha += 1 * Time.deltaTime;
    }
}
