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
    [SerializeField] private Image panelImage;
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
        if(numberQuetion < 85)
        { 
            QuestionList currentQuestion = questions[numberQuetion];
            questionText.text = currentQuestion.question;
            testScore++;
            numberQuetion++;
        }
        else if (numberQuetion == 85)
        {
            ScoreCounting();
        }
    }
    

    public void OnClickNoButton()
    {
        if(numberQuetion < 85)
        { 
            QuestionList currentQuestion = questions[numberQuetion];
            questionText.text = currentQuestion.question;
            numberQuetion++;
        }
        else if(numberQuetion == 85)
        {
            ScoreCounting();
        }
    }

    private void ScoreCounting()
    {
        scorePanel.SetActive(true);
        if(testScore < 20)
        {
            panelImage.sprite = goslings.Find(((gosling) => gosling.GoslingCollection.id == 5)).GoslingCollection.Image;
            finalText.text = "Вы Тачки Гослинг";
        }
        else if (testScore > 20 && testScore < 30)
        {
            panelImage.sprite = goslings.Find(((gosling) => gosling.GoslingCollection.id == 3)).GoslingCollection.Image;
            finalText.text = "Вы Славный Гослинг";
        }
        else if (testScore > 30 && testScore < 40)
        {
            panelImage.sprite = goslings.Find(((gosling) => gosling.GoslingCollection.id == 0)).GoslingCollection.Image;
            finalText.text = "Вы Барби Гослинг";
        }
        else if (testScore > 40 && testScore < 50)
        {
            panelImage.sprite = goslings.Find(((gosling) => gosling.GoslingCollection.id == 4)).GoslingCollection.Image;
            finalText.text = "Вы Гослинг пофигист";
        }
        else if (testScore > 60 && testScore < 75)
        {
            panelImage.sprite = goslings.Find(((gosling) => gosling.GoslingCollection.id == 2)).GoslingCollection.Image;
            finalText.text = "Вы Драйв Гослинг";
            
        }
        else if (testScore > 75)
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