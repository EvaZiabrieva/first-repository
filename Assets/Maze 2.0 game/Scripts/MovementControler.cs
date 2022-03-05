using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControler : MonoBehaviour
{
    public CharacterController Controller;
    public float PlayerSpeed = 5f;
    void Start()
    {
        
    }

    void Update()
    {
        Vector3 move = new Vector3(-Input.GetAxis("Vertical"), 0, Input.GetAxis("Horizontal"));
        move *= PlayerSpeed * Time.deltaTime;
        Controller.Move(move);
    }
}
