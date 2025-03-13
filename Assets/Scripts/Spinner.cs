using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xAxisRotation = 0.0f;
    [SerializeField] float yAxisRotation = 1.0f;
    [SerializeField] float zAxisRotation = 0.0f;

    // Update is called once per frame
    private void Update()
    {
        transform.Rotate(xAxisRotation, yAxisRotation, zAxisRotation);
    }
}
