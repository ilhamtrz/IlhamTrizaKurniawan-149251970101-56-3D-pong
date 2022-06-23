using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int p1Score;
    public int p2Score;
    public int p3Score;
    public int p4Score;
    public PaddleController p1;
    public PaddleController p2;
    public PaddleController p3;
    public PaddleController p4;

    public GameObject gameOverCanvas;
    public Text winnerText;
    private int playerActive;
    // Start is called before the first frame update
    //public int maxScore;
    //public BallController ball;

    private void Start()
    {
        playerActive = 4;
    }

    private void Update()
    {
        if(playerActive == 1)
        {
            GameOver();
        }
    }

    public void AddP1Score(int increment)
    {
        p1Score -= increment;
        //ball.ResetBall();

        if (p1Score == 0)
        {
            p1.isEliminated = true;
            playerActive--;
        }
    }

    public void AddP2Score(int increment)
    {
        p2Score -= increment;
        //ball.ResetBall();

        if (p2Score == 0)
        {
            p2.isEliminated = true;
            playerActive--;
        }
    }
    public void AddP3Score(int increment)
    {
        p3Score -= increment;
        //ball.ResetBall();

        if (p3Score == 0)
        {
            p3.isEliminated = true;
            playerActive--;
        }
    }
    public void AddP4Score(int increment)
    {
        p4Score -= increment;
        //ball.ResetBall();

        if (p4Score == 0)
        {
            p4.isEliminated = true;
            playerActive--;
        }
    }

    public void GameOver()
    {
        string playerWins = "Player X Wins";
        gameOverCanvas.SetActive(true);
        if (!p1.isEliminated)
        {
            playerWins = "Player 1 Wins";
        }
        else if (!p2.isEliminated)
        {
            playerWins = "Player 2 Wins";
        }
        else if (!p3.isEliminated)
        {
            playerWins = "Player 3 Wins";
        }
        else if (!p4.isEliminated)
        {
            playerWins = "Player 4 Wins";
        }
        winnerText.text = playerWins.ToString();
    }
}
