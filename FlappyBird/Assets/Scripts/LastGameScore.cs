using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LastGameScore : MonoBehaviour
{
    public TMP_Text LastPoint;

    void Start()
    {
        LastPoint.text = PlayerPrefs.GetInt("Score", 0).ToString();

    }
}
