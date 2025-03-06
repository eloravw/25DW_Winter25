using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class notifPanelBehaviour : MonoBehaviour
{

    [Header("UI Elements")]
    public TextMeshProUGUI glyph;
    public TextMeshProUGUI translation;

    public void GetClue(string i_glyph, string i_translation)
    {
        glyph.SetText(i_glyph);
        translation.SetText(i_translation);

    }

    public void CloseClue()
    {
        gameObject.SetActive(false);
    }

}
