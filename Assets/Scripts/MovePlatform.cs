using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    public float speed = 1f;
    public Vector3 targetPosition;
    public Vector3 initialPosition;

    public float waitSeconds = 0;
    public float waitStart = 0;

    public bool startTrigger = false;

    public bool forward = true;

    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
        StartCoroutine(WaitStart(waitStart));
    }
    IEnumerator WaitStart(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        startTrigger = true;
    }

    IEnumerator Wait(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        forward = !forward;
    }

    // Update is called once per frame
    void Update()
    {
        if (startTrigger == false)
            return;

        float step = speed * Time.deltaTime;
        
        if (forward && Vector3.Distance(transform.position, targetPosition) != 0f)
        {
            transform.position = Vector3.MoveTowards(transform.position,  targetPosition, step);
            if (Vector3.Distance(transform.position, targetPosition) == 0f)
            {
                StartCoroutine(Wait(waitSeconds));               
            }
        }
        else if (forward == false && Vector3.Distance(transform.position, initialPosition) != 0f)
        {
            transform.position = Vector3.MoveTowards(transform.position,  initialPosition, step);
            if (Vector3.Distance(transform.position, initialPosition) == 0f)
            {
                StartCoroutine(Wait(waitSeconds));
            }                
        }
    }
}
