using UnityEngine;

public class PlatformMover : MonoBehaviour
{
    public Rigidbody Rigidbody;
    public bool IsMoving;
    public Vector3 Offset = new Vector3(0f, 0f, 5f);
    public float ReversePosition = 3f;
    private float timer = 0f;
    private float directionManipulator = 1f;
    private Vector3 startPosition;
    
    private void Start()
    {
        startPosition = transform.position;
    }
    
    private void FixedUpdate()
    {
        if (!IsMoving)
            return;
        timer += Time.fixedDeltaTime * directionManipulator;
        if (timer >= ReversePosition )
            directionManipulator = -1f;
        if(timer <= 0)
            directionManipulator = 1f;
        Rigidbody.MovePosition(Offset * timer + startPosition);
    }

    public void ResetPlatform()
    {
        Rigidbody.MovePosition(startPosition);
        timer = 0f;
        directionManipulator = 1f;
    }
}
