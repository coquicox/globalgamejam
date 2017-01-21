﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Character : MonoBehaviour
{
    public GravityReferential Referential;
    private Rigidbody2D _rigidbody2D;
    // Use this for initialization
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        //_rigidbody2D.constraints = RigidbodyConstraints2D.FreezeRotation;
        _rigidbody2D.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Referential.Attract(transform);
    }
}

