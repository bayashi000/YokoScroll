﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoragonController : MonoBehaviour
{
    float speed = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += this.transform.forward * speed * Time.deltaTime;
    }
}