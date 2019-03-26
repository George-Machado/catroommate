using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEditor;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class BackgroundChange : MonoBehaviour
{
    public static BackgroundChange Instance;
    
    public Image background;
    public Sprite[] rooms;

    public int currentRoom;

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

        background = GetComponent<Image>();
        currentRoom = 0;
    }

   

    public void ChangeRooms()
    {
        if(currentRoom < rooms.Length-1)
        {
            currentRoom++;
            background.sprite = rooms[currentRoom];
        }
        else
        {
            currentRoom = 0;
            background.sprite = rooms[currentRoom];
        }
        
        ConversationManager.Instance.UpdateQuestionDisplay();
    }
    
       
}