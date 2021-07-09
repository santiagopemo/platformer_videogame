using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.Find("MenuButton").gameObject.GetComponent<Button>().onClick.AddListener(MainMenu);
        transform.Find("NextButton").gameObject.GetComponent<Button>().onClick.AddListener(Next);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Next()
    {
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (sceneIndex < 3)
            SceneManager.LoadScene(sceneIndex + 1);
        else
            MainMenu();
    }
}
