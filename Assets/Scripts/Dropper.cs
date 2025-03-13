using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] private float timeToWait = 3.0f;
    MeshRenderer dropperMeshRenderer;
    Rigidbody dropperRigidbody;

    private void Start()
    {
        dropperRigidbody = GetComponent<Rigidbody>();
        dropperRigidbody.useGravity = false;

        dropperMeshRenderer = GetComponent<MeshRenderer>();
        dropperMeshRenderer.enabled = false;
    }

    // Update is called once per frame
    private void Update()
    {
        if (Time.time >= timeToWait)
        {
            dropperRigidbody.useGravity = true;
            dropperMeshRenderer.enabled = true;
        }
    }
}
