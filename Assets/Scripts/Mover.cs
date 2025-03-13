using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 6f;

    private void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    private void Update()
    {
        MovePlayer();
    }

    private void PrintInstructions() 
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Move your player with WASD or arrow keys");
        Debug.Log("Don't hit the walls!");
    }

    private void MovePlayer()
    {
        float xMoveSpeed = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yMoveSpeed = 0.0f;
        float zMoveSpeed = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xMoveSpeed, yMoveSpeed, zMoveSpeed);
    }
}
