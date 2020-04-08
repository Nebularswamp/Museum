using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;

    public float walkspeed = 4f;
    public float runspeed = 12f;
    public CharacterController cc;

    public bool isRunning;
    public bool isGrounded;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        cc.Move(move * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftShift))
        {
            isRunning = true;
            speed = runspeed;
        }
        else
        {
            isRunning = false;
            speed = walkspeed;
        }

    }
}
