using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ball : MonoBehaviour
{
    public static Rigidbody ballRb;
    public TextMeshProUGUI playerScoreText;
    public TextMeshProUGUI enemyScoreText;
   
    public static TextMeshProUGUI bestScoreEkran;

    public int playerScore;
    public int enemyScore;

    void Awake()
    {
        ballRb = GetComponent<Rigidbody>();
        transform.position = ballRb.position;
        //Cursor.visible = false;    
        Invoke("GoBall", 3.0f);        
        playerScore = 0;
        enemyScore = 0;

        GameObject obje = GameObject.Find("bestScoreText");
        bestScoreEkran = obje.GetComponent<TextMeshProUGUI>();

        BestScore();
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerGoal"))
        {
            playerScore++;
            playerScoreText.text = "Score: " + playerScore;
            DataManager.Instance.score++;
            ResetBall();
            Invoke("RandomizeBallPositionAtStart", 2.0f);

        }
        else if (collision.gameObject.CompareTag("EnemyGoal"))
        {
            enemyScore++;
            enemyScoreText.text = "Score: " + enemyScore;
            ResetBall();
            Invoke("RandomizeBallPositionAtStart", 2.0f);
            
        }

    }
    void RandomizeBallPositionAtStart()
    {
        float rand = Random.Range(0, 2);
        if (rand < 1)
        {
            ballRb.AddForce(new Vector3(40,1, -40),ForceMode.Impulse);            
        }
        else
        {
            ballRb.AddForce(new Vector3(-40,1, -40),ForceMode.Impulse);
        }
        
    }
    void ResetBall()
    {
        ballRb.velocity = Vector3.zero;
        transform.position = Vector3.zero;
    }
    public void BestScore()
    {
        if (playerScore > PlayerPrefs.GetInt("HighScore",0))
        {
            PlayerPrefs.SetInt("HighScore", 0);
            playerScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        }
    }
    
}
