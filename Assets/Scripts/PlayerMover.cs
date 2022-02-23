using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    public float PlayerSpeed = 2f;
    public float ForwardSpeed = 2f;
    
    private void Update()
    {
        transform.position += new Vector3(
            Input.GetAxis("Horizontal") * PlayerSpeed,
            0, 
            ForwardSpeed)
            * Time.deltaTime;
    }
}
