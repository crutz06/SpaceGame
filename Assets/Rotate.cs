﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float Speed;



    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Rotate(Vector3.up, Speed);
    }
}
