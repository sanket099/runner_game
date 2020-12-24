using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void Replay(){
        SceneManager.LoadScene("Game");
    }
    // Start is called before the first frame update
   
}
