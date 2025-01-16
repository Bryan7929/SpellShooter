using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using JetBrains.Annotations;


public class PlayerFlip : MonoBehaviour
{

    void Start(){
    }

    private void Update(){
        Flip();
    }

    void Flip(){
        if (Keyboard.current.rightArrowKey.wasPressedThisFrame)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        if (Keyboard.current.leftArrowKey.wasPressedThisFrame)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
    }

}
