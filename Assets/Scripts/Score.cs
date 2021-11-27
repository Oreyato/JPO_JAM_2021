using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameManager gameManager;

    private string text;
    private string scoreText;

    // Start is called before the first frame update
    void Awake()
    {
        text = "Time: ";
        scoreText = gameManager.GetComponent<GameManager>().scoreText;
        
        GetComponent<Text>().text = "ERROR";        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText = gameManager.GetComponent<GameManager>().scoreText;
        GetComponent<Text>().text = text + scoreText;
    }
}
