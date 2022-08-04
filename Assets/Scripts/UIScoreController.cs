using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScoreController : MonoBehaviour
{
    [SerializeField] private Text score;
    [Header("UI")]
    
    public Text highScore;

    [Header("Score")]
    public ScoreController scoreController;

    private void Update()
    {
        score.text = scoreController.GetCurrentScore().ToString();
        highScore.text = ScoreData.highScore.ToString();
    }
}
