using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ConversationManager : MonoBehaviour
{
    public string[] livingRoomQ;
    public string[] livingRoomRight;
    public string[] livingRoomLeft;
    
    public string[] kitchenQ;
    public string[] kitchenRight;
    public string[] kitchenLeft;
    
    public string[] bathroomQ;
    public string[] bathroomRight;
    public string[] bathroomLeft;

    public static ConversationManager Instance;
    
 
    public bool[] isLeftCorrect = new bool[7]; 
    
    public TextMeshProUGUI questionText;
    public Text answerRightText;
    public Text answerLeftText;
    
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        
        DontDestroyOnLoad(this);
    }

    // Start is called before the first frame update
    void Start()
    {
        UpdateQuestionDisplay();

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void AnswerSelect()
    {
        GameManager.Instance.currentQuestion++;
        UpdateQuestionDisplay();
        Final();
    }

    public void UpdateQuestionDisplay()
    {
        var currentQuestion = GameManager.Instance.currentQuestion;
        
        switch (BackgroundChange.Instance.currentRoom)
        {
            case 0 when currentQuestion < livingRoomQ.Length:
                questionText.text = livingRoomQ[currentQuestion];
                answerLeftText.text = livingRoomLeft[currentQuestion];
                answerRightText.text = livingRoomRight[currentQuestion];
                break;
            case 1 when GameManager.Instance.currentQuestion < kitchenQ.Length:
                questionText.text = kitchenQ[GameManager.Instance.currentQuestion];
                answerLeftText.text = kitchenLeft[currentQuestion];
                answerRightText.text = kitchenRight[currentQuestion];
                break;
            default:
                questionText.text = bathroomQ[GameManager.Instance.currentQuestion];
                answerLeftText.text = bathroomLeft[currentQuestion];
                answerRightText.text = bathroomRight[currentQuestion];
                break;
        }
    }

  public void IsGood(bool leftSelected)
  {
     
      if (isLeftCorrect[GameManager.Instance.currentQuestion] == leftSelected) 
      {
          
          GameManager.Instance.aggressive++;
          CatChange.Instance.CatFace();
      }
      else
      {
       
          GameManager.Instance.bitchMade++;
          CatChange.Instance.CatFace();
      }

      AnswerSelect();
      Debug.Log(GameManager.Instance.aggressive);
     // GameManager.Instance.currentQuestion++;
  }

  public void Final()
  {
      if (GameManager.Instance.currentQuestion == 7)
      {
          if (GameManager.Instance.aggressive > GameManager.Instance.bitchMade)
          {
              questionText.text = "Ok dude I'm out";
          }
          else
          {
              questionText.text = "I'm having a few people over it'll be a small party 100-150 max";
          }
      }
      /*
      if (GameManager.Instance.aggressive >= 18 && GameManager.Instance.currentQuestion == 7)
      {
          questionText.text = "Ok dude I'm out";
      }
      else if(GameManager.Instance.mood <= 18 && GameManager.Instance.currentQuestion == 7)
      {
          questionText.text = "I'm having a few people over it'll be a small party 100-150 max";
      } */
  }


}

