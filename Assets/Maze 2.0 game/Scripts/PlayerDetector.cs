using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetector : MonoBehaviour
{
    public PlatformMover PlatformMover;
    private void OnTriggerEnter(Collider other)
    {
        PlatformMover.IsMoving = true;
    }
    private void OnTriggerExit(Collider other)
    {
        PlatformMover.IsMoving = false;
    }
}
