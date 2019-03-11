using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEditor;
using UnityEngine;

public class SpriteChange : MonoBehaviour
{
    
    public SpriteRenderer sr; 
    public Sprite[] spriteList;
    void Start()
    {
       sr = GetComponent<SpriteRenderer>();
       
    
    }

    // Update is called once per frame
    void Update()
    {
       CatFace();
    }

    public void CatFace()
    {
        if (GameManager.Instance.mood > 2)
        sr.sprite = spriteList[5];
    }

}