using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ConversationManager : MonoBehaviour
{
    public string[] questions;

    public string[] answersRight;
    public string[] answersLeft;

    public TextMeshProUGUI questionText;
    public Text answerRightText;
    public Text answerLeftText;
    // Start is called before the first frame update
    void Start()
    {
        DisplayQuestions();
        DisplayAnswers();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameManager.Instance.currentQuestion++;
            GameManager.Instance.currentAnswer++;
            DisplayQuestions();
            DisplayAnswers();
        }
    }

    void DisplayQuestions()

    {
        if (GameManager.Instance.currentQuestion < questions.Length) {
            questionText.text = questions[GameManager.Instance.currentQuestion];
        }
    }

    void DisplayAnswers()
    {
        if (GameManager.Instance.currentAnswer < answersLeft.Length)
        {
            answerLeftText.text = answersLeft[GameManager.Instance.currentAnswer];
        }

        if (GameManager.Instance.currentAnswer < answersRight.Length)
        {
            answerRightText.text = answersRight[GameManager.Instance.currentAnswer];
        }

    }

    void LogLeftAnswers()
    {
        
    }

    void LogRightAnswers()
    {
        
    }

}

