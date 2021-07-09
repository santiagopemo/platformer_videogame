using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseCanvas;
    public bool paused;
    // Start is called before the first frame update
    public AudioMixerSnapshot pausedSnapshot;
    public AudioMixerSnapshot unpausedSnapshot;
    private float initailBGMVolume;
    void Start()
    {
        // Cursor.visible = false;
        // Cursor.lockState = CursorLockMode.Confined;
        paused = false;
        Time.timeScale = 1;
        pauseCanvas.transform.Find("RestartButton").gameObject.GetComponent<Button>().onClick.AddListener(Restart);
        pauseCanvas.transform.Find("MenuButton").gameObject.GetComponent<Button>().onClick.AddListener(MainMenu);
        pauseCanvas.transform.Find("OptionsButton").gameObject.GetComponent<Button>().onClick.AddListener(Options);
        pauseCanvas.transform.Find("ResumeButton").gameObject.GetComponent<Button>().onClick.AddListener(Resume);
        unpausedSnapshot.TransitionTo(0.01f);
        SceneManager.activeSceneChanged += ChangeActiveScene;
    }

    void ChangeActiveScene(Scene current, Scene next)
    {
        Time.timeScale = 1;
        unpausedSnapshot.TransitionTo(0.01f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (paused)
                Resume();
            else
                Pause();
        }        
    }

    public void Pause()
    {
        // Cursor.visible = true;
        // Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0;
        pauseCanvas.SetActive(true);
        paused = true;
        pausedSnapshot.TransitionTo(0.01f);
    }

    public void Resume()
    {
        Time.timeScale = 1;
        pauseCanvas.SetActive(false);
        paused = false;
        unpausedSnapshot.TransitionTo(0.01f);
        // Cursor.visible = false;
        // Cursor.lockState = CursorLockMode.Confined;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Options()
    {
        PlayerPrefs.SetString("previous-scene", SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("Options");
    }
}
