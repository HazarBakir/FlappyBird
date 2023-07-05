using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameStarter : MonoBehaviour
{
    public int startingNumber = 3;
    public PlayerMove playermove;
    private float countdownTimer;
    public GameObject player;
    public GameObject ground;
    public TMP_Text gameStartCounter;
    public TMP_Text pointCounter;
    public GameObject gamecontroller;
    // Start is called before the first frame update
    void Start()
    {
        pointCounter.enabled = false;
        countdownTimer = startingNumber;
        player.SetActive(false);
        ground.SetActive(false);
        gamecontroller.SetActive(false);
        
        
    }


    // Update is called once per frame
    void Update()
    {
        countdownTimer -= Time.deltaTime;
        int currentNumber = Mathf.CeilToInt(countdownTimer);
        gameStartCounter.SetText(currentNumber.ToString());


        if (countdownTimer <= 0)
        {
            gameStartCounter.enabled = false;
            gamecontroller.SetActive(true);
            player.SetActive(true);
            ground.SetActive(true);
            pointCounter.enabled = true;
        }
        
    }

}
