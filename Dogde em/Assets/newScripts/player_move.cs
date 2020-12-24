using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_move : MonoBehaviour
{
    public float forwardForce = 2000f;
    public float sideForce = 500f;
    public Rigidbody rb;
    public float forceMulti = 1.5f;
     private float screenCenterX;
    // Start is called before the first frame update
    void Start()
    {
        screenCenterX = Screen.width * 0.5f;
        
    }

   

    void FixedUpdate(){
        
        if(rb.position.y < 20f){
            FindObjectOfType<GameManager>().EndGame();
        }
        if(rb.position.y >100f){
            rb.AddForce(0f,0f,0f);
        }else{
        
        rb.AddForce(0,0,forwardForce * forceMulti * Time.deltaTime );}

         rb.AddForce(0,0,forwardForce * forceMulti * Time.deltaTime );

        
        if(Input.GetKey("d")){
            rb.AddForce(sideForce * Time.deltaTime, 0 ,0, ForceMode.VelocityChange);

        }
        else if(Input.GetKey("a")){
            rb.AddForce(-sideForce * Time.deltaTime, 0 ,0, ForceMode.VelocityChange);
            
        }
        for(int i = 0 ; i<Input.touchCount; i++){
            Vector3 v = Camera.main.ScreenToWorldPoint(Input.touches[i].position);
        
        if(Input.GetTouch(i).position.x > screenCenterX){
            rb.AddForce(sideForce * Time.deltaTime, 0 ,0, ForceMode.VelocityChange);

        }
        else if(Input.GetTouch(i).position.x<screenCenterX){
            rb.AddForce(-sideForce * Time.deltaTime, 0 ,0, ForceMode.VelocityChange);
            
        }
        }


        
    }
}