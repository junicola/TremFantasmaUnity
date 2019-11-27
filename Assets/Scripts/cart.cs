﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cart : MonoBehaviour
{    
    float velTransl;
    float velRot;

    void Start()
    {
        this.velTransl = 0.02f;
        velRot = 5f;
    }
    void Update()
    {        
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(-velTransl, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(velTransl, 0, 0);
        }
        if (Input.GetKey(KeyCode.Z))
        {
            transform.Rotate(0,0,-90*velRot);
        }
    }

}
