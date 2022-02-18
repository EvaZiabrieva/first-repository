using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    public float PlayerSpeed = 2f;
    public float ForwardSpeed = 2f;
    void Update()
    {
        Vector3 offset = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        Vector3 forwardSpeedSet = new Vector3(0, 0, ForwardSpeed);
        transform.position += forwardSpeedSet.normalized * Time.deltaTime * ForwardSpeed;
        transform.position += offset.normalized * Time.deltaTime * PlayerSpeed;
    }
}
