using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Stats : MonoBehaviour
{
    // Class used to denote character stats in the game.
    [SerializeField]
    float HP, Atk, Def, Int, Drg, Spd; // vars representing Stats
    [SerializeField]
    TMP_Text UIdisp; // textBox that shows UI

    private float[] all_stats; // array unsed to hold stats
    private string[] stat_names; // array used to hold stat names

    public void Start()
    {
        // initializes stat arrays
        all_stats = new float[]{HP, Atk, Def, Int, Drg, Spd};
        stat_names = new string[] {"HP", "Atk", "Def", "Int", "Drg", "Spd"};
        if(UIdisp)
        {
            UIdisp.text = "Stats" + "\n";
            for(int i = 0; i < all_stats.Length; i++)
            {
                UIdisp.text += stat_names[i] + ": " + all_stats[i].ToString() + "\n";
            }
        }

    }


}
