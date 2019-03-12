using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEditor;
using UnityEngine;

public class SpriteChange : MonoBehaviour
{
    public static SpriteChange Instance;
    
    public SpriteRenderer sr; 
    public Sprite[] spriteList;
    void Start()
    {
       sr = GetComponent<SpriteRenderer>();
       Instance = this;


    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void CatFace()
    {
        if (GameManager.Instance.mood > 2)
        {
            sr.sprite = spriteList[Random.Range(0,6)];
        }
        else if(GameManager.Instance.mood == 2)
        {
            sr.sprite = spriteList[Random.Range(7, 11)];
        }
    }

}