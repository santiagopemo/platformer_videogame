using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private GameObject player;
    private bool mouseDown = false;
    public bool isInverted;
    private Transform parentTransform;
    private Vector3 localRotation;
    public float mouseSensitivity = 5f;
    public float orbitDampening = 15f;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        if (PlayerPrefs.HasKey("InvertYToggle"))
            isInverted = PlayerPrefs.GetInt("InvertYToggle") == 0 ? false : true;
        else
            isInverted = false;
        parentTransform = transform.parent;
        // Set Initials conditions if there are wrong in editor
        parentTransform.position = player.transform.position;
        transform.position = new Vector3(0f, 2.5f, -6.25f);
        transform.rotation = Quaternion.Euler(9, 0, 0);
    }
    void LateUpdate()
    {
        parentTransform.position = player.transform.position;
        if (Input.GetMouseButtonDown(1))
            mouseDown = true;
        if (Input.GetMouseButtonUp(1))
            mouseDown = false;
        if (mouseDown)
        {
            if (Input.GetAxis("Mouse X") != 0 || Input.GetAxis("Mouse Y") != 0)
            {
                localRotation.x += Input.GetAxis("Mouse X") * mouseSensitivity;
                if (isInverted)
                    localRotation.y -= Input.GetAxis("Mouse Y") * mouseSensitivity;
                else
                    localRotation.y += Input.GetAxis("Mouse Y") * mouseSensitivity;
                localRotation.y = Mathf.Clamp(localRotation.y, -60, 80);
            }
        }
        Quaternion QT = Quaternion.Euler(localRotation.y, localRotation.x, 0);
        parentTransform.rotation = Quaternion.Lerp(parentTransform.rotation, QT, orbitDampening); 
    }
}
