using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using JetBrains.Annotations;

public class PlayerMover : MonoBehaviour
{
    public float movSpeed;
    float speedX, speedY;

    bool movingY = false;
    bool movingX = false;

    Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.RightArrow)||Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if(movingX)
            {
                speedY = 0;
                movingX = true;
            }
            speedX = Input.GetAxisRaw("Horizontal") * movSpeed;
            rb.linearVelocity = new Vector2(speedX, speedY);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow)||Input.GetKeyDown(KeyCode.DownArrow))
        {
            if(movingY)
            {
                speedX = 0;
                movingY = true;
            }
            speedY = Input.GetAxisRaw("Vertical") * movSpeed;
            rb.linearVelocity = new Vector2(speedX, speedY);
        }
        if(Input.GetKeyUp(KeyCode.LeftArrow)||Input.GetKeyUp(KeyCode.RightArrow))
        {
            movingX = false;
            speedX = 0;
            rb.linearVelocity = new Vector2(speedX, speedY);
        }
        if(Input.GetKeyUp(KeyCode.UpArrow)||Input.GetKeyUp(KeyCode.DownArrow))
        {
            movingY = false;
            speedY = 0;
            rb.linearVelocity = new Vector2(speedX, speedY);
        }
 
    }
}






        /*
        speedX = Input.GetAxisRaw("Horizontal") * movSpeed;
        speedY = Input.GetAxisRaw("Vertical") * movSpeed;
        rb.linearVelocity = new Vector2(speedX, speedY);
        */