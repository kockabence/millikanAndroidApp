using UnityEngine;
using UnityEngine.UI;

public class scorekeeper : MonoBehaviour
{
    private int _currentScore = 0;
    private int count = 0;
    public void IncrementScore()
    {
        _currentScore++;
        Text scoreText = GetComponent<Text>();
        scoreText.text = "Pontszám: " + _currentScore.ToString();
    }

    void Update()
    {
        count++;

        if (count % 30 == 0)
        {
            IncrementScore();
        }
        
    }
}