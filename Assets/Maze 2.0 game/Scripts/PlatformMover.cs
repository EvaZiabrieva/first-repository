using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMover : MonoBehaviour
{
    public Vector3 Offset = new Vector3(0f, 0f, 5f);
    //public float MovingSpeed = 5f;
    public float ReversePosition = 3f;
    private float timer = 0f;
    private float directionManipulator = 1f;
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= ReversePosition)
        {
            directionManipulator *= -1f;
            timer -= ReversePosition;
        }
        transform.position += Offset * directionManipulator * Time.deltaTime;
    }
}
