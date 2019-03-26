using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEditor;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class CatChange : MonoBehaviour
{
    public static CatChange Instance;
    
    public SpriteRenderer catRenderer; 
    public Sprite[] spriteList;

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

    void Start()
    {
       catRenderer = GetComponent<SpriteRenderer>();
    }


       


    public void CatFace()
    {
        if (GameManager.Instance.bitchMade > 2)
        { 
            catRenderer.sprite = spriteList[Random.Range(0,6)];
        }
        else if(GameManager.Instance.aggressive > 2)
        {
            catRenderer.sprite = spriteList[Random.Range(7, 11)];
        }
    }

}