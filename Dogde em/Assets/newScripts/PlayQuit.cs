﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayQuit : MonoBehaviour
{
    // Start is called before the first frame update

    public void PlayGame(){
        SceneManager.LoadScene("Game");
    }
    public void Quit(){
        Application.Quit();
    }
   
}
