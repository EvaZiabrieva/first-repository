using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private Transform _camera;
    [SerializeField, Min(0f)] private float _speed = 10f;

    private void FixedUpdate()
    {
        _rigidbody.MoveRotation(Quaternion.Euler(Input.GetAxis("Vertical"), _speed * Input.mousePosition.x, Input.GetAxis("Horizontal")));
        
    }
}
