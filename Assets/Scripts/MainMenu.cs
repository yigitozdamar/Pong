using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public TextMeshProUGUI bestScoreText;
    
    private void Start()
    {
        bestScoreText.text = DataManager.Instance.BestScore.ToString(); 
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
