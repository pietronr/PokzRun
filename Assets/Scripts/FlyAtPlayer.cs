using UnityEngine;

public class Homing : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1.0f;
    private float actualMoveSpeed;
    [SerializeField] private Transform player;

    Vector3 playerPos;

    private void Awake()
    {
        gameObject.SetActive(false);
    }

    private void Start()
    {
        playerPos = player.transform.position;
    }

    // Update is called once per frame
    private void Update()
    {
        MoveTowardsPlayer();
    }

    private void MoveTowardsPlayer() 
    {        
        actualMoveSpeed = moveSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, playerPos, actualMoveSpeed);

        DestroyWhenReached();
    }

    private void DestroyWhenReached() 
    {
        if (transform.position == playerPos)
        {
            Destroy(gameObject);
        }
    }
}
