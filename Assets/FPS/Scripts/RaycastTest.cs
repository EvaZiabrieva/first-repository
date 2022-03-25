using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastTest : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private Material material;

    private MeshRenderer previouslyChanged;
    private Material previousMaterial;

    private void FixedUpdate()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 100f))
        {
            target.position = hit.point;

            MeshRenderer meshRenderer = hit.transform.GetComponent<MeshRenderer>();

            if (previouslyChanged != null)
            {
                previouslyChanged.material = previousMaterial;
            }

            previouslyChanged = meshRenderer;
            previousMaterial = meshRenderer.material;

            meshRenderer.material = material;
            target.gameObject.SetActive(true);
        }
        else
        {
            previouslyChanged.material = previousMaterial;
            target.gameObject.SetActive(false);
        }
    }
}
