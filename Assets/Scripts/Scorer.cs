using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int hits = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Hit") == false) 
        {
            Debug.Log($"You've bumped into {++hits} objects!");
        }
    }
}
