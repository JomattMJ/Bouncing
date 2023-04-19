using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBouncing : MonoBehaviour
{
    public Vector3 bouncingForce;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb= GetComponent<Rigidbody>();
        rb.AddForce(bouncingForce,ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
