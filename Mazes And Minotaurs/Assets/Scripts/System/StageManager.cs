using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageManager : MonoBehaviour
{
                     public  float currentTime;
    [SerializeField] private float maxTime = 60f;
                     private bool  gameActive = false;
    [SerializeField] private float lightInitialIntensity = 10f;
    [SerializeField] private GameObject Player;

    private void Start()
    {
        GameObject.Find("Player");
        Application.targetFrameRate = 60;
        Player.GetComponent<PlayerMain>().myTorch.myLight.intensity = lightInitialIntensity;



    }

    void Update()
    {
        if (gameActive == true)
        {
            Timer();
            UpdateTorch();
        }

    }

    private void UpdateTorch()
    {
        if (Player.GetComponent<PlayerMain>().myTorch.lightActive == true)
        {
            Player.GetComponent<PlayerMain>().myTorch.myLight.intensity = lightInitialIntensity * TimerPromedio(); 

        }
    }

    private void Timer()
    {
        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;            
            if (currentTime <= 0)
            {
                print("Time's out. You loose");
                RestartScene();
            }
        }
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(0);
    }


    public void RefillTimer()
    {
        if (gameActive == false) gameActive = true;
        currentTime = maxTime;
    }

    private float TimerPromedio()
    {
        return currentTime / maxTime;
    }


}
