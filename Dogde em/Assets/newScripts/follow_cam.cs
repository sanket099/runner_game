﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow_cam : MonoBehaviour
{
    public Transform player; 
    public Vector3 vector;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform .position = player.position + vector;
        
    }
}
