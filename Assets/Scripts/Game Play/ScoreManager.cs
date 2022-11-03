using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int rightScore;
    public int leftScore;
    [SerializeField] int maxScore;
    [SerializeField] BallController ball;

    // func Add Score Right
    public void AddRightScore(int increment)
    {
        ball.ResetBall();
        rightScore += increment;
        if (rightScore >= maxScore)
            GameOver();
    }

    // func Add Score Left
    public void AddLeftScore(int increment)
    {
        ball.ResetBall();
        leftScore += increment;
        if (leftScore >= maxScore)
            GameOver();
    }

    // func Game Over
    public void GameOver()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
