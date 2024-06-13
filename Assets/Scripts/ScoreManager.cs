using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreVal;
    public TextMeshProUGUI finalScoreText;
    public GameObject deathScreen;
    private int currentScore = 0;
    public void updateScore(int addToScore)
    {
        currentScore += addToScore;
    }
    private void Update()
    {
        scoreVal.text = "" + currentScore;
    }
    public void youDied()
    {
        deathScreen.SetActive(true);
        finalScoreText.text = "Final Score: " + currentScore;
    }
}
