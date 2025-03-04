using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class OuijaBoard : MonoBehaviour
{
    [Header("Valid Queries")]
    public string[] validQueries;

    [Header("Translations")]
    public string[] translations;

    [Header("Letter Locations")]
    public GameObject[] letter_loc;

    [Header("Planchet")]
    public GameObject planchet;
    public float waitTime;

    [Header("Input")]
    public TextMeshProUGUI input;


    private char[] alphabet = {'a','b','c','d','e','f','g','h','i','j','k', 'l', 'm', 'n', 'o', 'p', 'q',
    'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
    private string returnWord;
    private int letterIndex;
    private planchetMovement planchetScript;
    private IEnumerator coroutine;

    // Start is called before the first frame update
    void Start()
    {
        planchetScript = planchet.GetComponent<planchetMovement>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void newQuery(string enteredWord)
    {
        returnWord = "";

        string query = enteredWord.Trim();
        if (query.Length > 0)
        {
            //Debug.Log("Searching for " + enteredWord);
        }

        for (int i = 0; i < validQueries.Length; i++)
        {
            if (query.Equals(validQueries[i], System.StringComparison.OrdinalIgnoreCase))
            {
                returnWord = translations[i];
                //Debug.Log(returnWord);
                StartCoroutine (showResult(returnWord));
                return;
            }

        }

        if (returnWord == "")
        {
            noResult();
        }

    }

    void noResult()
    {
        Debug.Log("That is not a valid entry.");
    }


    private IEnumerator showResult(string result)
    {
        char[] letters = new char[result.Length];

        for (int j = 0; j < result.Length; j++)
        {
            char newLetter = result[j];
            letters[j] = newLetter;

            //Debug.Log(newLetter);

        }

        for (int k = 0; k < letters.Length; k++)
        {
            for (int l = 0; l < alphabet.Length; l++)
            {

                if (letters[k].Equals(alphabet[l]))
                {
                    letterIndex = l;
                    //Debug.Log(letter_loc[letterIndex]);
                    GameObject currentTarget = letter_loc[letterIndex];

                    planchetScript.MoveToTarget(currentTarget);
                    yield return new WaitForSeconds(waitTime);

                }
                

            }
        }

        planchetScript.ReturnToCenter();
    }
}
