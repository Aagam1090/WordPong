using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int scorePlayer1, scorePlayer2;
    public ScoreText scoreTextLeft, scoreTextRight;
    public BallText ballText;
    private string res1;
    private string res2;

    public void OnScoreZoneReached(int id)
    {
        res1 = scoreTextLeft.GetScore();
        res2 = scoreTextRight.GetScore();
        if (id == 1)
        {
            if (res1.Equals("-"))
            {
                string curr = ballText.getText();
                res1 = curr;
            }
            else
            {
                string curr = ballText.getText();
                res1 = scoreTextRight.GetScore() + curr;
            }
            
        }
        else
        {
            if (res2.Equals("-"))
            {
                string curr = ballText.getText();
                res2 = curr;
            }
            else
            {
                string curr = ballText.getText();
                res2 = scoreTextRight.GetScore() + curr;
            }
        }

        UpdateScores();
    }
    public void UpdateScores()
    {
        scoreTextLeft.SetScore(res1);
        scoreTextRight.SetScore(res2);
    }
}
