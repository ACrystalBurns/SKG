using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDrive : MonoBehaviour
{
    public float thrust;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Get input
        float transf = Input.GetAxis("Vertical") * thrust;
        float rotate = Input.GetAxis("Horizontal") * thrust;

        //Make kart respond to key presses
        rb.AddForce(rotate, 0, transf, ForceMode.VelocityChange);
        transform.Rotate(Vector3.up * Time.deltaTime * rotate * 10, Space.Self);

        //Adjust direction
        Vector3 veloc = new Vector3(rb.velocity.x, transform.position.y, rb.velocity.z);
        transform.LookAt(transform.position + rb.velocity);
    }
}
