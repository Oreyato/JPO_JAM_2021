using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [Range(1,4)]
    public int playerID;
    public Gamepad gamepad;
    Rigidbody m_RigidBody;
    public float maxSpeed;
    public float m_thrust;
    public float speed ;
    public float torque;
    float turn;
    
    public enum DIRECTION
    {
        LEFT,
        RIGHT
    }

    public DIRECTION direction = DIRECTION.LEFT;
    public float goForward = 1;


    // Start is called before the first frame update
    void Awake()
    {
        maxSpeed = 15;
        m_RigidBody = GetComponent<Rigidbody>();
        Debug.Log(Gamepad.all.Count);
        if (Gamepad.all.Count >= playerID)
        {
            gamepad = Gamepad.all[playerID - 1];
        }
   
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(this.transform.position.z);
        speed = m_RigidBody.velocity.magnitude;
        Debug.Log(speed);
        
        turn = (direction == DIRECTION.LEFT?-1:1);
        // testing current speed
        if(speed > maxSpeed)
        {
            float brakespeed = speed - maxSpeed; 
            Vector3 normalizedvelocity = m_RigidBody.velocity.normalized;
            Vector3 brakevelocity = normalizedvelocity * brakespeed;

           m_RigidBody.AddForce(-brakevelocity);
        }

        if (gamepad != null)
        {
            if (gamepad.buttonSouth.wasPressedThisFrame)
            {
                goForward = 1;
                OnActionInput();
            }
            else if (gamepad.buttonEast.wasPressedThisFrame) {
                goForward = -1;
                OnActionInput();

            }

        }
    }

    public void OnActionInput()
    {
        //Define behaviour an action input
        Debug.Log("Player " + playerID + " has done action " + (direction == DIRECTION.LEFT ? "left" : "right"));
        //this.transform.Translate(0.2f, 0f, 1f);
        m_RigidBody.AddForce(goForward*transform.forward * m_thrust, ForceMode.Impulse);
        m_RigidBody.AddTorque(goForward * transform.up * torque * turn);
       
        
        
        
    }

    public void SmoothForward()
    {

    }
}
