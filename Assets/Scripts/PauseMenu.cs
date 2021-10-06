using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject gameScreen, pauseScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PauseButton()
    {
        Time.timeScale = 0;
        gameScreen.SetActive(false);
        pauseScreen.SetActive(true);

    }
    public void ResumeButton()
    {
        Time.timeScale = 1;
        gameScreen.SetActive(true);
        pauseScreen.SetActive(false);
    }
    public void MainMenuButton()
    {
        SceneManager.LoadScene(0);
    }
    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }
}
