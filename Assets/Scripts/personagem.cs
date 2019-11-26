﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personagem : MonoBehaviour
{
    float velTransl;
    float velRot;

    void Start()
    {
        this.velTransl = 0.1f;
        this.velRot = 5f;
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
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(0, velTransl, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0, -velTransl, 0);
        }
        if (Input.GetKey(KeyCode.Z))
        {
            transform.Rotate(0, 0, -velRot);
        }
        if (Input.GetKey(KeyCode.X))
        {
            transform.Rotate(0, 0, velRot);
        }
    }

}
