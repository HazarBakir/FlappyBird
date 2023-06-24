using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HiScore : MonoBehaviour
{
    public TMP_Text highScore;
    // Start is called before the first frame update
    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }
}
