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
    private bool[] _isLeftCorrect = new bool[7];
   

    public TextMeshProUGUI questionText;
    public Text answerRightText;
    public Text answerLeftText;

    // Start is called before the first frame update
    void Start()
    {
        DisplayQuestions();
        _isLeftCorrect[0] = true;
        _isLeftCorrect[1] = true;
        _isLeftCorrect[2] = false;
        _isLeftCorrect[3] = false;
        _isLeftCorrect[4] = true;
        _isLeftCorrect[5] = true;
        _isLeftCorrect[6] = true;

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

  public void DisplayQuestions()

    {
        if (GameManager.Instance.currentQuestion < questions.Length) {
            questionText.text = questions[GameManager.Instance.currentQuestion];
        }  
        if (GameManager.Instance.currentQuestion < answersLeft.Length)
                 {
                     answerLeftText.text = answersLeft[GameManager.Instance.currentQuestion];
                 }
         
    if (GameManager.Instance.currentQuestion < answersRight.Length)
                 {
                     answerRightText.text = answersRight[GameManager.Instance.currentQuestion];
                 }
    }

  public void IsGood(bool leftSelected)
  {
      if (_isLeftCorrect[GameManager.Instance.currentQuestion] == leftSelected) /// good answer
      {
          // good code
          GameManager.Instance.mood++;
      }
      else
      {
          // bad code
          GameManager.Instance.mood--;
      }

      Debug.Log(GameManager.Instance.mood);
      GameManager.Instance.currentQuestion++;
  }


}

