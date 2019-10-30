using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDrive : MonoBehaviour
{
    public float speed = 5.0f; //Speed of kart
    public float rotSpeed = 5.0f;  //Rotation speed of kart

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Make kart respond to key presses
        if (Input.GetKey(KeyCode.W))    //^
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed, Space.Self);
        }

        if (Input.GetKey(KeyCode.S))   //v
        {
            transform.Translate(Vector3.forward * Time.deltaTime * -speed, Space.Self);
        }

        if (Input.GetKey(KeyCode.A))   //<
        {
            transform.Rotate(Vector3.up * Time.deltaTime * -rotSpeed, Space.Self);
        }

        if (Input.GetKey(KeyCode.D))   //>
        {
            transform.Rotate(Vector3.up * Time.deltaTime * rotSpeed, Space.Self);
        }
    }
}
