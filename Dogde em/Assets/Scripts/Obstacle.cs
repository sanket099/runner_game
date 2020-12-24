using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // Start is called before the first frame update
    Player playerMovement;

	private void Start () {
        playerMovement = GameObject.FindObjectOfType<Player>();
	}

    private void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.name == "Player") {
            // Kill the player
            playerMovement.Die();
        }
    }

    private void Update () {
	
	}
}
