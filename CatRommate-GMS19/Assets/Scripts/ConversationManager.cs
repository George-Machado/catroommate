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

    private bool[] _isLeftCorrect;
   

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
        AnswerSelect();
    }

   public void AnswerSelect()
    {
        if (Input.GetMouseButtonDown(0))
            
        {
            GameManager.Instance.currentQuestion++;
          
            DisplayQuestions();
            
        }
    }

  public   void DisplayQuestions()

    {
        if (GameManager.Instance.currentQuestion < questions.Length) {
            questionText.text = questions[GameManager.Instance.currentQuestion];
        }
    }

   public void DisplayAnswers()
    {
        if (GameManager.Instance.currentQuestion < answersLeft.Length)
        {
            answerLeftText.text = answersLeft[GameManager.Instance.currentQuestion];
        }

        if (GameManager.Instance.currentQuestion < answersRight.Length)
        {
            answerRightText.text = answersRight[GameManager.Instance.currentQuestion];
        }

    }

  public void LogAnswers()
    {
        
    }


}

