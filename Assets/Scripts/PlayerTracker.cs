using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTracker : MonoBehaviour
{
    public Transform trackedCar;

    public Vector3 velocity = Vector3.one;
    public Vector3 defaultDistance;
    public float distance;

    void Awake()
    {

    }

    void LateUpdate()
    {
        if (!trackedCar) return;

        Vector3 toPosition = trackedCar.position + (trackedCar.rotation * defaultDistance);
        Vector3 currentPosition = Vector3.SmoothDamp(transform.position, toPosition, ref velocity, distance);

        transform.LookAt(trackedCar);
    }
}
