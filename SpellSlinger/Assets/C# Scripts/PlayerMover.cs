using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using JetBrains.Annotations;

public class PlayerMover : MonoBehaviour
{
    public float movSpeed;
    float speedX, speedY;
    Rigidbody2D rb;


    void Start() 
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            MoveRight();
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            speedX = 0;
            rb.linearVelocity = new Vector2(speedX, speedY);
        }
//___________________________________________________________________________________________
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            MoveLeft();
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            speedX = 0;
            rb.linearVelocity = new Vector2(speedX, speedY);
        }
//___________________________________________________________________________________________
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            MoveUp();
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            speedY = 0;
            rb.linearVelocity = new Vector2(speedX, speedY);
        }
//___________________________________________________________________________________________
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            MoveDown();
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            speedY = 0;
            rb.linearVelocity = new Vector2(speedX, speedY);
        }
    }

    public void MoveLeft()
    {
        speedX = -movSpeed;
        speedY = 0;
        rb.linearVelocity = new Vector2(speedX, speedY);
    }
    public void MoveRight()
    {
        speedX = movSpeed;
        speedY = 0;
        rb.linearVelocity = new Vector2(speedX, speedY);
    }
    public void MoveUp()
    {
        speedX = 0;
        speedY = movSpeed;
        rb.linearVelocity = new Vector2(speedX, speedY);
    }
    public void MoveDown()
    {
        speedX = 0;
        speedY = -movSpeed;
        rb.linearVelocity = new Vector2(speedX, speedY);
    }
}





        /*
        speedX = Input.GetAxisRaw("Horizontal") * movSpeed;
        speedY = Input.GetAxisRaw("Vertical") * movSpeed;
        rb.linearVelocity = new Vector2(speedX, speedY);
        */
        /*
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
 
    }*/