using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMain : MonoBehaviour
{
    [HideInInspector] public Transform target;
    [HideInInspector] public EnemyMovement movement;
    [HideInInspector] public EnemyStats stats;
    [HideInInspector] public Animator myAnimator;
    void Start()
    {
        target = GameObject.Find("Player").transform;
        movement = GetComponent<EnemyMovement>();
        myAnimator = GetComponentInChildren<Animator>();
        stats = GetComponent<EnemyStats>();
    }


}
