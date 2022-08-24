using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    private PlayerMain mainScript;
    [SerializeField] private NewSignal WalltorchTouch;
    private bool isVulnerable = true;
    [SerializeField] private float invulnerableTime = 2f;
    private float invulnerableTimeCurrent;
    

    private void Start()
    {
        mainScript = GetComponent<PlayerMain>();
    }
    private void Update()
    {
        if (!isVulnerable)
        {
            invulnerableTimeCurrent -= Time.deltaTime;
            if(invulnerableTimeCurrent <= 0)
            {
                isVulnerable = true;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        print($"player collided with: {other.gameObject.tag}");
        switch (other.gameObject.tag)
        {
            case "WinPoint":
                print("You won");
                break;
            case "WallTorch":
                mainScript.myTorch.TurnOn();
                WalltorchTouch?.Raise();
                print("Player touched a Walltorch");
                break;
            case "Enemy":
                if (isVulnerable) 
                { 
                    mainScript.health.TakeDamage(other.GetComponent<EnemyMain>().stats.damagePower);
                    isVulnerable = false;
                    invulnerableTimeCurrent = invulnerableTime;
                }
                break;
        }

              
    }

   
}
