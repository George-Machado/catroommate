using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int currentQuestion;
    public int mood;
    public int aggressive;
    public int bitchMade;
   
  
    // Start is called before the first frame update

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
        
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        currentQuestion = 0;
        mood = 0;
        aggressive = 0;
        bitchMade = 0;

    }


    // Update is called once per frame
    void Update()
    {

    }
}

 