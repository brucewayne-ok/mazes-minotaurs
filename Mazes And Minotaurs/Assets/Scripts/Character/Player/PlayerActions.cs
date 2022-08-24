using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    private PlayerMain mainScript;
    void Start()
    {
        mainScript = GetComponent<PlayerMain>();
    }

    
    void Update()
    {
        if(mainScript.myTorch.lightActive == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                mainScript.myTorch.BoostRange();
            }

            if (Input.GetMouseButtonUp(0))
            {
                mainScript.myTorch.BoostRange();
            }
        }
    }
}
