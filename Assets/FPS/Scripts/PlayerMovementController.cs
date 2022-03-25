using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private Transform _camera;
    [SerializeField, Min(0f)] private float _rotationHorizontalSensetivity = 10f;
    [SerializeField, Min(0f)] private float _rotationVerticalSensetivity = 10f;
    [SerializeField, Range(-90f, 90f)] private float _minVericalAngle = -50f;
    [SerializeField, Range(-90f, 90f)] private float _maxVericalAngle = 50f;

    private void FixedUpdate()
    {
        _rigidbody.MoveRotation(Quaternion.Euler(0f, _rotationHorizontalSensetivity * Input.mousePosition.x, 0f));
        _camera.localRotation = Quaternion.Euler(Mathf.Clamp(-_rotationVerticalSensetivity * Input.mousePosition.y, _minVericalAngle, _maxVericalAngle), 0f, 0f);
    }
}
