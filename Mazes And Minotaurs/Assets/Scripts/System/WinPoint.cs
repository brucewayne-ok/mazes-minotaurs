using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinPoint : MonoBehaviour
{
    [SerializeField] private float maxDistance = 3f;
    [SerializeField] private NewSignal win;

    // Update is called once per frame
    void Update()
    {
        CheckForPlayer();
    }

    void CheckForPlayer()
    {
        RaycastHit hit;
        if(Physics.Raycast(this.transform.position, this.transform.TransformDirection(Vector3.forward), out hit, maxDistance))
        {
            if (hit.transform.CompareTag("Player"))
            {
                win?.Raise();
            }   
        }
    }
}
