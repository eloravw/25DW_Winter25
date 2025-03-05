using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OuijaBoard : MonoBehaviour
{
    [Header("Valid Queries")]
    public string[] validQueries;

    [Header("Translations")]
    public string[] translations;

    [Header("Letter Locations")]
    public GameObject a_loc;
    public GameObject b_loc;
    public GameObject c_loc;
    public GameObject d_loc;
    public GameObject e_loc;
    public GameObject f_loc;
    public GameObject g_loc;
    public GameObject h_loc;
    public GameObject i_loc;
    public GameObject j_loc;
    public GameObject k_loc;
    public GameObject l_loc;
    public GameObject m_loc;
    public GameObject n_loc;
    public GameObject o_loc;
    public GameObject p_loc;
    public GameObject q_loc;
    public GameObject r_loc;
    public GameObject s_loc;
    public GameObject t_loc;
    public GameObject u_loc;
    public GameObject v_loc;
    public GameObject w_loc;
    public GameObject x_loc;
    public GameObject y_loc;
    public GameObject z_loc;

    [Header("Planchet")]
    public GameObject planchet;

    [Header("Input")]
    public TextMeshProUGUI input;

    private string returnWord;

    // Start is called before the first frame update
    void Start()
    {
        
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
            Debug.Log("Searching for " + enteredWord);
        }

        for (int i = 0; i < validQueries.Length; i++)
        {
            if (query.Equals(validQueries[i], System.StringComparison.OrdinalIgnoreCase))
            {
                returnWord = translations[i];
                Debug.Log(returnWord);
                return;
            }

            i++;
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
}
