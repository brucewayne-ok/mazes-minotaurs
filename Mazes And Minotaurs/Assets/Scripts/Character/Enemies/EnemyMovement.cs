using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private EnemyMain mainScript;
    [SerializeField] private float speedRotation = 10f;
    [SerializeField] private float speedWalk = 10f;
    [SerializeField] private float chaseRange = 5f;
    [SerializeField] private float stopRange = 2f;

    private void Start()
    {
        mainScript = GetComponent<EnemyMain>();
    }

    private void Update()
    {
        Look(mainScript.target, speedRotation);
        MoveTowards(mainScript.target, speedWalk, chaseRange, stopRange);
    }

    public void Look(Transform who, float speed)
    {
        Quaternion newRotation = Quaternion.LookRotation(who.position - transform.position);
        newRotation.x = 0;
        newRotation.z = 0;
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, speed * Time.deltaTime);
    }

    public void MoveTowards(Transform who, float speed, float start, float stop)
    {
        Vector3 dir = (who.position - transform.position);
        dir.y = 0;
        if (dir.magnitude > stop && dir.magnitude < start)
        {
            transform.position += speed * dir.normalized * Time.deltaTime;
            mainScript.myAnimator.SetBool("isWalking", true);

        }
        else
        {
            mainScript.myAnimator.SetBool("isWalking", false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
