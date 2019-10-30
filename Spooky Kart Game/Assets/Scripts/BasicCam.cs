using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicCam : MonoBehaviour
{
    public GameObject kart; //Stores reference to kart
    private Vector3 offset; //Stores offset distance between kart and camera

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - kart.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //Sets camera position to be same as kart's, but offset by calculated offset distance
        transform.position = kart.transform.position + offset;
    }
}
