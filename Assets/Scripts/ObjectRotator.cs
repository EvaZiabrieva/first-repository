using UnityEngine;

public class ObjectRotator : MonoBehaviour
{
    public float RotatePerSecond = 30f;

    private void Update()
    {
        transform.Rotate(0f, RotatePerSecond * Time.deltaTime, 0f);
    }
}
