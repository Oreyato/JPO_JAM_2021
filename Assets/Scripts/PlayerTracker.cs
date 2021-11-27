using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTracker : MonoBehaviour
{
    public Transform trackedCar;
    public float maxDistance = 13;
    public float moveSpeed = 20;
    public float updateSpeed = 10;

    [Range(0, 10)]
    public float currentDistance = 3.25f;

    private GameObject ahead;
    private Rigidbody _rigidbody;
    private string moveAxis = "Mouse ScrollWheel";

    void Awake()
    {
        ahead = new GameObject("ahead");
        _rigidbody = trackedCar.gameObject.GetComponent<Rigidbody>();
    }


    void LateUpdate()
    {
        ahead.transform.position = trackedCar.position + trackedCar.forward * (maxDistance * 0.25f);
        currentDistance += _rigidbody.velocity.z * moveSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, trackedCar.position + Vector3.up * currentDistance - trackedCar.forward * (currentDistance + maxDistance * 0.5f), updateSpeed * Time.deltaTime);
        transform.LookAt(ahead.transform);
    }
}
