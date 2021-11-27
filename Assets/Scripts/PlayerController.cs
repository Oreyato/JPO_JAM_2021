using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [Range(1,4)]
    public int playerID;
    public Gamepad gamepad;
    public enum DIRECTION
    {
        LEFT,
        RIGHT
    }

    public DIRECTION direction = DIRECTION.LEFT;


    // Start is called before the first frame update
    void Start()
    {
        if (Gamepad.all.Count >= playerID)
        {
            gamepad = Gamepad.all[playerID - 1];
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (gamepad!= null && gamepad.buttonSouth.wasPressedThisFrame)
        {
            OnActionInput();
        }
    }

    public void OnActionInput()
    {
        //Define behaviour an action input
        Debug.Log("Player " + playerID + " has done action " + (direction == DIRECTION.LEFT ? "left" : "right"));
    }
}
