using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuBGM : MonoBehaviour
{
    private static MainMenuBGM instance;
    private AudioSource audioSource;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else if (instance != this)
            Destroy(this.gameObject);
    }
    void Start()
    {
        SceneManager.activeSceneChanged += ChangeActiveScene;
    }

    void ChangeActiveScene(Scene current, Scene next)
    {
        if (next.name != "Options" && next.name != "MainMenu")
        {
            if (this != null)
                Destroy(this.gameObject);
        }            
    }
}
