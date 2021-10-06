using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class DataManager : MonoBehaviour
{
    public static DataManager Instance;
    public GameObject bestScoreText;
    public int score, bestScore;
    
    // Start is called before the first frame update
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);


        bestScoreText.GetComponent<TextMeshProUGUI>().text = score.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        if (bestScore< score)
        {
            bestScoreText.GetComponent<TextMeshProUGUI>().text = score.ToString();
        }
    }
}
