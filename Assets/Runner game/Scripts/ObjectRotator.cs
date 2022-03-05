using UnityEngine;

public class ObjectRotator : ObjectManipulatorBase
{
    public Vector3 RotatePerSecond = new Vector3(0f, 30f, 0f);

    public override void Manipulate(float directionMultiplicator)
    {
        transform.Rotate(RotatePerSecond * directionMultiplicator * Time.deltaTime);
    }
}
