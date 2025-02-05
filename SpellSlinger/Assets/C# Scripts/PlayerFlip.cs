using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using JetBrains.Annotations;


public class PlayerFlip : MonoBehaviour
{
    /*
[SerializeField] private int RotateRight = 0;
[SerializeField] private int RotateLeft = 0;

[SerializeField] private int RotateUp = 0;
[SerializeField] private int RotateDown = 0;
*/
    void Start(){
    }

    private void Update(){
        Flip();
    }

    void Flip(){
        if (Keyboard.current.rightArrowKey.wasPressedThisFrame) //Right move
        {
            transform.eulerAngles = new Vector3(0, 0, 270);
        }
        if (Keyboard.current.leftArrowKey.wasPressedThisFrame) // Left move
        {
            transform.eulerAngles = new Vector3(0, 0, 90);
        }
            if (Keyboard.current.upArrowKey.wasPressedThisFrame) // Up move
        {
            transform.eulerAngles = new Vector3(0, 0, 360);
        }
            if (Keyboard.current.downArrowKey.wasPressedThisFrame) // Down move
        {
            transform.eulerAngles = new Vector3(0, 0, 180);
        }
    }

}
