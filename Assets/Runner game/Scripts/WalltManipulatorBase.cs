using UnityEngine;

public abstract class ObjectManipulatorBase : MonoBehaviour
{
    public float ReverseCycleDuration = 3f;
    private float timer = 0f;
    private float directionMultiplicator = 1f;

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= ReverseCycleDuration)
        {
            directionMultiplicator *= -1f;
            timer -= ReverseCycleDuration;
        }

        Manipulate(directionMultiplicator);
    }

    public abstract void Manipulate(float directionMultiplicator);
}
