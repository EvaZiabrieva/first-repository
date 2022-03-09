using UnityEngine;

public class MovementControler : MonoBehaviour
{
    public Rigidbody Rigidbody;
    public float PlayerSpeed = 5f;

    private void FixedUpdate()
    {
        Vector3 move = new Vector3(-Input.GetAxis("Vertical"), 0, Input.GetAxis("Horizontal"));
        move *= PlayerSpeed * Time.fixedDeltaTime;
        Rigidbody.MovePosition(move + transform.position);
    }
}
