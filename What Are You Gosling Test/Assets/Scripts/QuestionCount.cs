using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuestionCount : MonoBehaviour
{

    [SerializeField] private TMP_Text questionScoreText;
    private int score;

    void Start()
    {
        score = 0;
        questionScoreText.text = score + "/85";
    }
    
    public void OnClickScore()
    {
        if (score == 85)
        {
            Destroy(questionScoreText);
        }
        score++;
        questionScoreText.text = score + "/85";
    }
}
