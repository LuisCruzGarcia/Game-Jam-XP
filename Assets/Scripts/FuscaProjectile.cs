﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuscaProjectile : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.up * speed;
    }
}
