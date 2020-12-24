using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class newScore : MonoBehaviour
{
    public Transform player;
    public Text score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float pos = player.position.z / 100f;
        score.text = pos.ToString("0");
    }

    public float getScore(){
        return player.position.z/100f;
    }
}
