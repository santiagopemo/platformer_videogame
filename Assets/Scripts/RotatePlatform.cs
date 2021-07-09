using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlatform : MonoBehaviour
{
    public bool rotateInX = false;
    public float speedX = 10f;
    public bool rotateInY = false;
    public float speedY = 10f;
    public bool rotateInZ = false;
    public float speedZ = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (rotateInX)
            transform.Rotate(Vector3.right * Time.deltaTime * speedX);
        if (rotateInY)
            transform.Rotate(Vector3.up * Time.deltaTime * speedY);
        if (rotateInZ)
            transform.Rotate(Vector3.forward * Time.deltaTime * speedZ);
    }
}
