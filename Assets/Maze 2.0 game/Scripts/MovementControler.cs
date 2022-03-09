using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControler : MonoBehaviour
{
    public Rigidbody Rigidbody;
    public float PlayerSpeed = 5f;

    void Update()
    {
        Vector3 move = new Vector3(-Input.GetAxis("Vertical"), 0, Input.GetAxis("Horizontal"));
        move *= PlayerSpeed * Time.deltaTime;
        Rigidbody.MovePosition(move + transform.position);
    }
}
