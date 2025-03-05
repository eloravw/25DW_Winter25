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
    public List<AudioClip> skullSounds;

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
            RevealRune();
        }
    }

    public void OnLeftClick(GameObject activeSkull)
    {
        if (correctAnswer == false)
        {
            AudioSource audio = GetComponent<AudioSource>();

            skullOrder.Add(activeSkull);
            if (activeSkull == bSkull) audio.clip = skullSounds.ElementAt<AudioClip>(0);
            if (activeSkull == fSharpSkull) audio.clip = skullSounds.ElementAt<AudioClip>(1);
            if (activeSkull == fSkull) audio.clip = skullSounds.ElementAt<AudioClip>(2);
            if (activeSkull == aSharpSkull) audio.clip = skullSounds.ElementAt<AudioClip>(3);
            if (activeSkull == dSharpSkull) audio.clip = skullSounds.ElementAt<AudioClip>(4);
            if (activeSkull == dSkull) audio.clip = skullSounds.ElementAt<AudioClip>(5);

            audio.Play();

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
