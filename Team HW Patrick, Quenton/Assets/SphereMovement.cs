﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SphereMovingUpandDown();
    }

    void SphereMovingUpandDown()
    {
        float UpAndDown = Random.Range(0, 10);

        transform.position = new Vector3(0, UpAndDown, 0);

    }
}
