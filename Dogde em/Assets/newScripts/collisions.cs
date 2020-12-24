using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisions : MonoBehaviour
{
    public player_move move;
    //public GameManager gm;
    // Start is called before the first frame update
    public void OnCollisionEnter(Collision col){

        if(col.collider.tag == "obstacle"){
            move.enabled = false;
           // FindObjectOfType<newScore>().enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
