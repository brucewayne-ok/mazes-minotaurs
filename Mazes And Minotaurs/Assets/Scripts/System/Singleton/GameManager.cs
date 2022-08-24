using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int playerCredits;

    private void Awake()
    {
        if (instance == null) 
        { 
            instance = this; 
            DontDestroyOnLoad(gameObject); 
        }
        else 
        { 
            Destroy(gameObject); 
        }
    }

    private void Start()
    {
        Application.targetFrameRate = 60;
    }

    public void OnWin()
    {
        print("You won");
        RestartScene();
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(0);
    }

    public void TakeCredit()
    {
        playerCredits -= 1;
        if (playerCredits <= 0)
        {
           print("You run out of lives");        
        }
        RestartScene();
    }

    public void AddCredit(int num)
    {
        playerCredits += num;
        print($"Player added {num} credits. Current credits: {playerCredits}");
    }


}
