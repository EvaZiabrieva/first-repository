using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDetector : MonoBehaviour
{
    public Vector3 start;
    private void OnTriggerEnter(Collider other)
    {
        other.transform.position = start;
    }
}
