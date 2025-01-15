using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour
{
    void Start()
    {
        Debug.Log("MainMenuHandler working...");
    }
    void Update()
    {}

    public void Play(){
        SceneManager.LoadScene("Room#1");
    }
}