﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CapsuleMovingDown();
    }

    void CapsuleMovingDown()
    {
        transform.position += Vector3.down * 0.1f;
    }
}
