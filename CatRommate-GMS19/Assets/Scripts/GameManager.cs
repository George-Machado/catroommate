﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int currentQuestion;
    public int mood;

  
    // Start is called before the first frame update

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        currentQuestion = 0;
        mood = 0;
    }


    // Update is called once per frame
    void Update()
    {

    }
}

 