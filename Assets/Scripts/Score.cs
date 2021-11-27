using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameManager gameManager;

    private string scoreText;
    private float scoreValue;

    // Start is called before the first frame update
    void Awake()
    {
        scoreText = "Score: ";
        
        
        GetComponent<Text>().text = "ERROR";        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
