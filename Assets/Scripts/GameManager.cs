using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int scorePlayer1, scorePlayer2;
    public ScoreText scoreTextLeft, scoreTextRight;
    public BallText ballText;

    public string word = "APPLE";

    private string res1;
    private string res2;

    public void OnScoreZoneReached(int id)
    {
        res1 = scoreTextLeft.GetScore();
        res2 = scoreTextRight.GetScore();

        string curr = ballText.getText();
        if (id == 1)
        {
            res1 += curr;
        }
        else
        {
            res2 +=  curr;
        }
        int idx = Random.Range(0, word.Length);
        ballText.setText(word[idx].ToString());
        UpdateScores(res1,res2);
    }
    public void UpdateScores(string res1, string res2)
    {
        scoreTextLeft.SetScore(res1);
        scoreTextRight.SetScore(res2);
    }
}
