using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{
    
    private void Start()
    {
               
    }
    public void PlayMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitMenu()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }
  
}
