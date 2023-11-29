using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{

    public Text ScoreText;
    public Text highestScoreText;

    int score = 0;
    //int highestScore = 0;
    // Start is called before the first frame update

   
    void Start()
    {

        ScoreText.text = score.ToString();
        //highestScoreText.text = highestScore.ToString() + "highestScore";

    }

    public void AddPoints() {
        score = score + 1;
        ScoreText.text = score.ToString();

    }
}
