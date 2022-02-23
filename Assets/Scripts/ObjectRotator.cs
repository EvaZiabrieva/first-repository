using UnityEngine;

public class ObjectRotator : MonoBehaviour
{
    public Vector3 RotatePerSecond = new Vector3(0f, 30f, 0f);
    public float ReverseCycleDuration = 3f;
    private float timer = 0f;
    private float directionMultiplicator = 1f;

    private void Update()
    {
        timer += Time.deltaTime;
        if(timer >= ReverseCycleDuration)
        {
            directionMultiplicator *= -1f;
            timer -= ReverseCycleDuration;
        }
        transform.Rotate(RotatePerSecond * directionMultiplicator * Time.deltaTime);
    }
}
