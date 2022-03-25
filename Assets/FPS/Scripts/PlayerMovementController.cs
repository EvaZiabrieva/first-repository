using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private Transform _camera;
    [SerializeField, Min(0f)] private float _rotationHorizontalSensetivity = 10f;

    private void FixedUpdate()
    {
        _rigidbody.MoveRotation(Quaternion.Euler(0f, _rotationHorizontalSensetivity * Input.mousePosition.x, 0f));
    }
}
