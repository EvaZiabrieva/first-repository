using UnityEngine;

public class ObjectRotator : MonoBehaviour
{
    public Vector3 RotatePerSecond = new Vector3(0f, 30f, 0f);

    private void Update()
    {
        transform.Rotate(RotatePerSecond * Time.deltaTime);
    }
}
