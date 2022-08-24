using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMain : MonoBehaviour
{
    [HideInInspector] public CharacterController myCc;
    [HideInInspector] public PlayerMovement      movement;
    [HideInInspector] public PlayerCollisions    collisions;
    [HideInInspector] public PlayerActions       actions;
    [HideInInspector] public PlayerHealth        health;
                      public PlayerTorch         myTorch;

   

   
    void Start()
    {
        myCc       = GetComponent<CharacterController>();
        movement   = GetComponent<PlayerMovement>();
        collisions = GetComponent<PlayerCollisions>();
        actions    = GetComponent<PlayerActions>();
        health     = GetComponent<PlayerHealth>();

    }
}
