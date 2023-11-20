using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public float timeLeft;

    bool gameOver = false;
    bool win = false;

    public GameObject winText;
    public GameObject gameOverText;
    public GameObject ball;

    public PlayerController playerController;

    public TextMeshProUGUI timerText;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timeLeft >= 0 && !win)
        {
            timeLeft -= Time.deltaTime;
            timerText.text = timeLeft.ToString("F0"); //F0 nao mostra os numeros decimais
        }

        if(timeLeft <= 0 && !win)
        {
            GameOver();
        }
    }

    public void GameWin()
    {
        win = true;
        winText.SetActive(true);
        playerController.enabled = false;
        ball.SetActive(false);
    }

    public void GameOver()
    {
        gameOverText.SetActive(true);
        playerController.enabled = false;
        gameOver = true;
    }
}
