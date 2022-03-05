using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleManipulator : ObjectManipulatorBase
{
    public Vector3 ScaleDifPerSecond = new Vector3(0f, 5f, 0f);
    public override void Manipulate(float directionMultiplicator)
    {
        transform.localScale += ScaleDifPerSecond * directionMultiplicator * Time.deltaTime;
    }
}
