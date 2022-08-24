using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    private EnemyMain mainScript;
    public float damagePower = 1f;
    void Start()
    {
        mainScript = GetComponent<EnemyMain>();
    }
}
