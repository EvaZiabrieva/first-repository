using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallRotator : WallManipulatorBase
{
    public Vector3 Offset = new Vector3(0f, 0f, 5f);

    public override void Manipulate(float directionMultiplicator)
    {
        transform.Rotate(Offset * directionMultiplicator * Time.deltaTime);
    }
}
