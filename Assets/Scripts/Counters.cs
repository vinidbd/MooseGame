using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Counters : MonoBehaviour
{
    static public int points;
    public TMP_Text points_txt;
    public GameObject steak;
    void Update()
    {
        points_txt.text = "points:" + points;
    }
}
