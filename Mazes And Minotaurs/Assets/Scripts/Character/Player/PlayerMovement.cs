using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private PlayerMain mainScript;    
    public float gravityForce = 9.8f;
    [SerializeField] private float speed = 5f;
    private Vector3 directionPlayer;
    [SerializeField] private float speedRotate = 900f;
    private float cameraAxisX = 0f;
    [SerializeField]
    [Range(0, 20)]
    private float runSpeed = 10;
    private float walkSpeed = 5f;



    // Start is called before the first frame update
    void Start()
    {
        mainScript = GetComponent<PlayerMain>();

    }

    // Update is called once per frame
    void Update()
    {
        RotatePlayer();
        MovementSetup();
        RunPlayer();
        Gravity();

    }

    private void MovementSetup()
    {
        directionPlayer = Vector3.zero;
        directionPlayer.z = Input.GetAxisRaw("Vertical");
        directionPlayer.x = Input.GetAxisRaw("Horizontal");
        if (directionPlayer != Vector3.zero)
        {
            MovePlayer(directionPlayer);
        }
    }

    void Gravity()
    {
        mainScript.myCc.Move(Vector3.down * gravityForce * Time.deltaTime);
    }


    void MovePlayer(Vector3 direction)
    {
        mainScript.myCc.Move(transform.TransformDirection(direction) * speed * Time.deltaTime);
    }
    void RotatePlayer()
    {
        cameraAxisX = 0f;
        cameraAxisX += Input.GetAxis("Mouse X");
        transform.Rotate(Vector3.up * cameraAxisX * speedRotate * Time.deltaTime);


    }

    void RunPlayer()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = runSpeed;
        }
        else
        {
            speed = walkSpeed;
        }
    }



}