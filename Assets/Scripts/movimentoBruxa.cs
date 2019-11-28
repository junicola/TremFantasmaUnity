using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentoBruxa : MonoBehaviour
{
    float countdown = 0;
    void Start()
    {
    }

    void Update()
    {
        
        if(countdown % 2 == 0){
            transform.Translate(0.02f, 0, 0);
            transform.Translate(-0.02f, 0, 0);
            countdown -= Time.deltaTime;
        }
    }
}
