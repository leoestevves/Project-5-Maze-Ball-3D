using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] float timeLeft;

    //bool gameOver = false;
    bool win = false;

    [SerializeField] GameObject winText;
    [SerializeField] GameObject gameOverText;
    [SerializeField] GameObject ball;

    [SerializeField] PlayerController playerController;

    [SerializeField] TextMeshProUGUI timerText;

    [SerializeField] GameObject winPlane;



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
        //gameOver = true;
        winPlane.SetActive(false);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
