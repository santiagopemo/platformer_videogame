using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class TyController : MonoBehaviour
{
    private GameObject parent;
    private Animator animator;
    [Header("FX Audio Sources")]
    public AudioSource rockStep;
    public AudioSource grassStep;
    public AudioSource rockLanding;
    public AudioSource grassLanding;
    private float groundDistance = 1f;
    private bool isRock = true;

    private RaycastHit hit;
    private Ray footStepRay ;

    // Start is called before the first frame update
    void Start()
    {
        parent = transform.parent.gameObject;
        animator = GetComponent<Animator>();
    }

    public void TyIsFalling()
    {
        parent.GetComponent<PlayerController>().isFalling = true;
    }

    public void TyGotUp()
    {
        parent.GetComponent<PlayerController>().isFalling = false;
    }

    public void TyStep()
    {
        if(animator.GetBool("isGrounded"))
        {
            if (isRock)
                rockStep.Play();
            else
                grassStep.Play();
        }
    }
    public void FlatLanding()
    {
        if (isRock)
            rockLanding.Play();
        else
            grassLanding.Play();
    }

    void Update()
    {
        
        // Debug.DrawLine(transform.position, new Vector3(transform.position.x, transform.position.y - groundDistance, transform.position.z), Color.red, 2);
        if (animator.GetBool("isGrounded"))
        {
            // RaycastHit hit;
            // Ray footStepRay = new Ray (transform.position, Vector3.down);
            footStepRay.origin = transform.position;
            footStepRay.direction = Vector3.down; 
            if (Physics.Raycast(footStepRay, out hit, groundDistance))
            {
                // print(hit.transform.gameObject.name);
                // print(hit.transform.gameObject.GetComponent<MeshRenderer>().materials[0].name);
                MeshRenderer meshR = hit.transform.gameObject.GetComponent<MeshRenderer>();
                if (meshR != null)
                {
                    if (meshR.materials[0].name == "Stone (Instance)")
                    {
                        isRock = true;
                    }
                    else
                        isRock = false;
                }
            }
            
        }
    }
}
