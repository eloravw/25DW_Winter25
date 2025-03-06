using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;
using TMPro;

public class SkullManager : MonoBehaviour
{

    public TextMeshProUGUI runeText;

    public GameObject bSkull;
    public GameObject fSharpSkull;
    public GameObject fSkull;
    public GameObject aSharpSkull;
    public GameObject dSharpSkull;
    public GameObject dSkull;

    public List<GameObject> skullOrder;

    private bool correctAnswer = false;

    void Update()
    {
        if (skullOrder.ElementAt(0) == fSharpSkull &&
             skullOrder.ElementAt(1) == fSkull &&
             skullOrder.ElementAt(2) == dSharpSkull &&
             skullOrder.ElementAt(3) == aSharpSkull &&
             skullOrder.ElementAt(4) == bSkull &&
             skullOrder.ElementAt(5) == dSkull &&
             skullOrder.ElementAt(6) == aSharpSkull)
        {
            correctAnswer = true;
            GameManager.solvedMusicRoom = true;
        }

        if (GameManager.solvedMusicRoom)
        {
            RevealRune();
        }

    }

    public void OnLeftClick(GameObject activeSkull)
    {
        if (correctAnswer == false)
        {
            skullOrder.Add(activeSkull);

            if (skullOrder.Count > 7)
            {
                skullOrder.Remove(skullOrder.ElementAt(0));
            }
        }
    }

    void RevealRune()
    {
        runeText.alpha += 1 * Time.deltaTime;
    }
}
