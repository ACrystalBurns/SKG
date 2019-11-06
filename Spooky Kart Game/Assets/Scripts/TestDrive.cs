using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDrive : MonoBehaviour
{
    public float thrust;
    public float turnSpeed;
    public Rigidbody rb;
    public Collider coll;
    Vector3 eulerAngVelo;
    float distToGround;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        coll = GetComponent<Collider>();
        distToGround = coll.bounds.extents.y;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Get input
        float transf = Input.GetAxis("Vertical") * thrust;
        float rotate = Input.GetAxis("Horizontal") * turnSpeed;

        //Set up Quaternion
        eulerAngVelo = new Vector3(0, rotate, 0);
        Quaternion deltaRotation = Quaternion.Euler(eulerAngVelo * Time.deltaTime);

        //Make kart respond to key presses
        if (isGrounded())  //Makes sure kart is on ground
        {
            rb.AddForce(transform.forward * transf, ForceMode.VelocityChange);
            rb.MoveRotation(rb.rotation * deltaRotation);
        }
    }

    bool isGrounded()
    {
        return Physics.Raycast(transform.position, -Vector3.up, distToGround + 0.1f);
    }
}