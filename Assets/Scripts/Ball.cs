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


    void Awake()
    {
        ballRb = GetComponent<Rigidbody>();
        transform.position = ballRb.position;
        //Cursor.visible = false;    
        Invoke("RandomizeBallPositionAtStart", 3.0f);        
        DataManager.Instance.PlayerScore = 0;
        DataManager.Instance.EnemyScore = 0;

        GameObject obje = GameObject.Find("bestScoreText");
        bestScoreEkran = obje.GetComponent<TextMeshProUGUI>();

        
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerGoal"))
        {
            DataManager.Instance.PlayerScore++;
            playerScoreText.text = "Score: " + DataManager.Instance.PlayerScore;
            //DataManager.Instance.score++;
            ResetBall();
            Invoke("RandomizeBallPositionAtStart", 2.0f);

        }
        else if (collision.gameObject.CompareTag("EnemyGoal"))
        {
            DataManager.Instance.EnemyScore++;
            enemyScoreText.text = "Score: " + DataManager.Instance.EnemyScore;
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
}
