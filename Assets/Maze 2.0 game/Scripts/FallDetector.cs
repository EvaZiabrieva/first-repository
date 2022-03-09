using UnityEngine;

public class FallDetector : MonoBehaviour
{
    public Vector3 start;
    public PlatformList PlatformList;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.GetComponent<MovementControler>() != null)
        {
            collider.transform.position = start;
            for (int i = 0; i < PlatformList.PlatformMovers.Length; i++)
            {
                PlatformList.PlatformMovers[i].ResetPlatform();
            }
        }
    }
}
