using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PracticeDummy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Practice Dummy Deployed");
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Spell")
        {
            Debug.Log("Practice Dummy Destroyed");
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
