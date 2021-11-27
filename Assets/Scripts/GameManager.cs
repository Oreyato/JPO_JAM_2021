using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
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
        
    }
}
