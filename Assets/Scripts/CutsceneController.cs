using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneController : MonoBehaviour
{
    public GameObject player;
    public GameObject timerCanvas;

    public GameObject mainCamera;

    private string level;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        level = SceneManager.GetActiveScene().name;
        if (level == "Level01")
            animator.SetBool("isLevel01", true);
        if (level == "Level02")
            animator.SetBool("isLevel02", true);
        if (level == "Level03")
            animator.SetBool("isLevel03", true);
    }

    // Update is called once per frame
    public void OnIntroFisnished()
    {
        player.GetComponent<PlayerController>().enabled = true;
        timerCanvas.SetActive(true);
        mainCamera.SetActive(true);
        gameObject.SetActive(false);
    }
}
