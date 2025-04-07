using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;

    void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    public void SimulationOff()
    {
        _rigidbody2D.gravityScale = 0f;
        _rigidbody2D.freezeRotation = true;
        _rigidbody2D.simulated = false;
    }

    public void SimulationOn()
    {
            _rigidbody2D.gravityScale = 1;
            _rigidbody2D.freezeRotation = false;
            _rigidbody2D.simulated = true;
    }
}