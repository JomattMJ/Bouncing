using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncing : MonoBehaviour
{
    public float maxSpeed = 10f;
    private Vector3 direction = Vector3.one;
    public GameObject sideleft;
    public GameObject sideright;
    public GameObject down;
    public GameObject up;
    public GameObject left;
    public GameObject right;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * Time.deltaTime;

        //Comparing the object to transform postion and room wall position.

        if(transform.position.x < sideleft.transform.position.x || transform.position.x > sideright.transform.position.x)
        {
            direction.x = -direction.x;
        }
        if (transform.position.y < down.transform.position.y || transform.position.y > up.transform.position.y)
        {
            direction.y = -direction.y;
        }
        if (transform.position.z < right.transform.position.z || transform.position.z > left.transform.position.z)
        {
            direction.z = -direction.z;
        }
        
        //Control the speed of the object
        if(direction.magnitude >maxSpeed)
        {
            direction = direction.normalized * maxSpeed;
        }
    }
}
