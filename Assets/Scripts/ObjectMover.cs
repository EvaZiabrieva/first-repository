using UnityEngine;

public class ObjectMover : MonoBehaviour
{
    public Vector3 Offset = new Vector3(0, 0, 5f);
    public float ReverseCycleDuration = 3f;
    private float timer = 0f;
    private float directionMultipicator = 1f;

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= ReverseCycleDuration)
        {
            directionMultipicator *= -1f;
            timer -= ReverseCycleDuration;
        }
        
        transform.position += Offset * directionMultipicator * Time.deltaTime;
    }
}