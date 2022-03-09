using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDetector : MonoBehaviour
{
    public Vector3 start;
    public Vector3 platformStart;
    public PlatformMover PlatformMover;
    private void OnTriggerEnter(Collider other)
    {
        other.transform.position = start; 
        PlatformMover.transform.position = platformStart;
    }
}
