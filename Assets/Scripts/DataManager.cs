using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class DataManager : MonoBehaviour
{
    public static DataManager Instance;
    public int BestScore {
        get { return PlayerPrefs.GetInt("HighScore", 0); }
        set { PlayerPrefs.SetInt("HighScore", value);
            PlayerPrefs.Save(); } 
    }

    private int playerScore;
    private int enemyScore;
    public int PlayerScore { get { return playerScore; } 
        set {
            playerScore = value;
            if (BestScore < playerScore)
            {
                BestScore = playerScore;

            }
            
        } }

    public int EnemyScore { get { return enemyScore; } set { enemyScore = value; } }

    // Start is called before the first frame update
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            DestroyImmediate(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
                     

    }

}
