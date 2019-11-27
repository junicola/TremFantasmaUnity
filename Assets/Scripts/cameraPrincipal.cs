using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraPrincipal : MonoBehaviour
{
    float velRot;
    void Start()
    {
        this.velRot = 5f;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -velRot, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, velRot, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(-velRot, 0, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(velRot, 0, 0);
        }

        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (hit.transform.tag == "parede")
            {
                hit.transform.gameObject.GetComponent<Renderer>().material.color = Color.red;
            }
        }
    }
}