using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float xMoveSpeed = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yMoveSpeed = 0.0f;
        float zMoveSpeed = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xMoveSpeed, yMoveSpeed, zMoveSpeed);
    }
}
