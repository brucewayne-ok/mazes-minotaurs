using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private PlayerMain mainScript;
    [HideInInspector] public  float hpCurrent;
    [SerializeField]  private float hpMax;
    [SerializeField]  private NewSignal playerDied;
    void Start()
    {
        mainScript = GetComponent<PlayerMain>();
        RefillHp();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RefillHp()
    {
        hpCurrent = hpMax;
    }

    public void TakeDamage(float damage)
    {
        
        hpCurrent -= damage;
        if (hpCurrent < 0) hpCurrent = 0;
        if(hpCurrent <= 0)
        {
            PlayerDeath();
        }
        print($"Player took {damage} damage points. Current hp: {hpCurrent}");
    }

    public void PlayerDeath()
    {
        print("Player Died");
        playerDied?.Raise();
    }
}
