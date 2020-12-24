using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreTxt;
   

    // Update is called once per frame
    void Update()
    {
        float pos = player.position.z / 100f;
        scoreTxt.text = pos.ToString("0");
        
    }
}
