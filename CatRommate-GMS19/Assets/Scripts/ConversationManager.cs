using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ConversationManager : MonoBehaviour
{
    public string[] questions;
public st
    public string[] rooms;
    
    public string[] answersRight;
    public string[] answersLeft;
    public bool[] isLeftCorrect = new bool[7];
    public GameObject cat;

    public TextMeshProUGUI questionText;
    public Text answerRightText;
    public Text answerLeftText;
    
   

    // Start is called before the first frame update
    void Start()
    {
        DisplayQuestions();
       


    }

    // Update is called once per frame
    void Update()
    {
       
    }

   public void AnswerSelect()
    {
            GameManager.Instance.currentQuestion++;
            DisplayQuestions();
            Final();
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
     
      if (isLeftCorrect[GameManager.Instance.currentQuestion] == leftSelected) 
      {
          
          GameManager.Instance.mood++;
          SpriteChange.Instance.CatFace();
      }
      else
      {
       
          GameManager.Instance.mood--;
          SpriteChange.Instance.CatFace();
      }

      AnswerSelect();
      Debug.Log(GameManager.Instance.mood);
     // GameManager.Instance.currentQuestion++;
  }

  public void Final()
  {
      if (GameManager.Instance.mood >= 2 && GameManager.Instance.currentQuestion == 7)
      {
          questionText.text = "Let's be roommates";
      }
      else if(GameManager.Instance.mood <= 2 && GameManager.Instance.currentQuestion == 7)
      {
          questionText.text = "I can't live with you";
      }
  }


}

