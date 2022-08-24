using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTorch : MonoBehaviour
{
    private PlayerMain mainScript;
    [SerializeField] private GameObject myFlame;
    public Light myLight;    
    [HideInInspector] public bool lightActive = false;
    [SerializeField] private float lightRangeLow = 6f, lightRangeHigh = 12f;
  

    private bool lightBoost = false;
    void Start()
    {
        mainScript = GetComponent<PlayerMain>();
       
    }

 

    public void TurnOn()
    {
        myFlame.SetActive(true);        
        lightActive = true;
    }

    public void BoostRange()
    {

        if (lightBoost == false)
        {
            lightBoost = true;
            myLight.range = lightRangeHigh;
            print($"light range: {myLight.range}");
        }
        else
        {
            lightBoost = false;
            myLight.range = lightRangeLow;
            print($"light range: {myLight.range}");
        }
    }

    
   
}
