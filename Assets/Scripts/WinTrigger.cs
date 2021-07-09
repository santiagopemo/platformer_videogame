using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinTrigger : MonoBehaviour
{
    public GameObject player;
    public Text timerText;
    public GameObject winCanvas;
    public AudioSource cheeryMondayBGM;
    public AudioSource victoryPianoBGM;
    // Start is called before the first frame update
    void Start()
    {
         player = FindObjectOfType<PlayerController>().gameObject;
         victoryPianoBGM.Stop();
    }

    void OnTriggerEnter(Collider other)
    {
        player.GetComponent<Timer>().enabled = false;
        winCanvas.SetActive(true);
        player.GetComponent<PauseMenu>().enabled = false;
        player.GetComponent<Timer>().Win();
        cheeryMondayBGM.Stop();
        victoryPianoBGM.Play();
        Time.timeScale = 0;
    }
}
