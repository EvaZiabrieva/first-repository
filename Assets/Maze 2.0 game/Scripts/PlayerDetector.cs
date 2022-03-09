using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetector : MonoBehaviour
{
    public PlatformMover PlatformMover;
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.GetComponent<MovementControler>() != null)
        {
            PlatformMover.IsMoving = true;
        }
    }
    private void OnTriggerExit(Collider collider)
    {
        if (collider.GetComponent<MovementControler>() != null)
        {
            PlatformMover.IsMoving = false;
        }
    }
}
