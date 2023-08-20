using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TestQuestions : MonoBehaviour
{
    [SerializeField] private QuestionList[] questions;
    [SerializeField] private TMP_Text questionText;
    [SerializeField] private TMP_Text finalText;
    [SerializeField] private GameObject scorePanel;
    [SerializeField] private GameObject questionPanel;
    [SerializeField] private Image panelImage;
    [SerializeField] GameObject buttonYes;
    [SerializeField] GameObject buttonNo;
    [SerializeField] private List<PictureCollection> goslings = new List<PictureCollection>();
    private int numberQuetion;
    private string[] questionArray;
    private int randomQuetion;
    private int testScore;

    private void Start()
    {
        numberQuetion = 0;
        testScore = 0;
    }

    public void OnClickYesButton()
    {
        if(numberQuetion < 100)
        { 
            QuestionList currentQuestion = questions[numberQuetion];
            questionText.text = currentQuestion.question;
            testScore++;
            numberQuetion++;
        }
        else if (numberQuetion == 100)
        {
            ScoreCounting();
            buttonNo.SetActive(false);
            buttonYes.SetActive(false);
            questionPanel.SetActive(false);
        }
    }
    

    public void OnClickNoButton()
    {
        if(numberQuetion < 100)
        { 
            QuestionList currentQuestion = questions[numberQuetion];
            questionText.text = currentQuestion.question;
            numberQuetion++;
        }
        else if(numberQuetion == 100)
        {
            ScoreCounting();
            buttonNo.SetActive(false);
            buttonYes.SetActive(false);
            questionPanel.SetActive(false);
        }
    }

    private void ScoreCounting()
    {
        scorePanel.SetActive(true);
        if(testScore < 30)
        {
            panelImage.sprite = goslings.Find(((gosling) => gosling.GoslingCollection.id == 5)).GoslingCollection.Image;
            finalText.text = "Вы Обычный Гослинг";
        }
        else if (testScore >= 30 && testScore < 40)
        {
            panelImage.sprite = goslings.Find(((gosling) => gosling.GoslingCollection.id == 3)).GoslingCollection.Image;
            finalText.text = "Вы Славный Гослинг";
        }
        else if (testScore >= 40 && testScore < 50)
        {
            panelImage.sprite = goslings.Find(((gosling) => gosling.GoslingCollection.id == 0)).GoslingCollection.Image;
            finalText.text = "Вы Барби Гослинг";
        }
        else if (testScore >= 50 && testScore < 60)
        {
            panelImage.sprite = goslings.Find(((gosling) => gosling.GoslingCollection.id == 4)).GoslingCollection.Image;
            finalText.text = "Вы Гослинг в Красном";
        }
        else if (testScore >= 70 && testScore < 85)
        {
            panelImage.sprite = goslings.Find(((gosling) => gosling.GoslingCollection.id == 2)).GoslingCollection.Image;
            finalText.text = "Вы Драйв Гослинг";
        }
        else if (testScore > 85)
        {
            panelImage.sprite = goslings.Find(((gosling) => gosling.GoslingCollection.id == 1)).GoslingCollection.Image;
            finalText.text = "Вы Бегущий по лезвию Гослинг";
        }
        Destroy(questionText);
        Debug.Log(testScore);
    }

}

[System.Serializable]
public class QuestionList
{
    public string question;
    public string[] answers = new string[2];
}