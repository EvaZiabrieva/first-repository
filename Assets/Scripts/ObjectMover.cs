using UnityEngine;

public class ObjectMover : ObjectManipulatorBase
{
    public Vector3 Offset = new Vector3(0, 0, 5f);
   
    public override void Manipulate(float directionMultiplicator)
    {
        transform.position += Offset * directionMultiplicator * Time.deltaTime;
    }
}