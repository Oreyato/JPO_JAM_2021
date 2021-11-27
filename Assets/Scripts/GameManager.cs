using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    public GameObject ship;
    public float score;
    public string scoreText;
    
    private float timer;
    private int minutes;
    private int seconds;
    private float decimals;
    private bool gameStarted = true;

    private float start;

    // Start is called before the first frame update
    void Start()
    {
        start = Time.time;
        InputSystem.onDeviceChange +=
            (device, change) =>
            {
                switch (change)
                {
                    case InputDeviceChange.Added:
                        // New Device.
                        break;
                    case InputDeviceChange.Disconnected:
                        // If this is happening, activate some boolean that will tell the game that a controller is now "missing".
                        break;
                    case InputDeviceChange.Reconnected:
                        // Plugged back in.
                        break;
                    case InputDeviceChange.Removed:
                        // Remove from Input System entirely; by default, Devices stay in the system once discovered.
                        break;
                    default:
                        // Always includes a default case for when a unused case is being called. Leave it empty.
                        break;
                }
            };
    }

    // Update is called once per frame
    void Update()
    {
        if (gameStarted)
        {
            timer += Time.deltaTime;
            Score();
        }
        else timer = 0;
        
        
    }

    void Score()
    {
        decimals = (float)(Time.time - start)%1;
        minutes = (int)decimals / 60;

        //scoreText = minutes.ToString() + ":" + decimals;
        int timeElapsed = (int)(Time.time - start);
        scoreText = string.Format("{0}'{1:00}\"{2:00}", timeElapsed / 60 , timeElapsed % 60 , Math.Round((decimals)*100,2));
    }
}
