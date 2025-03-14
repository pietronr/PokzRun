using System.Collections.Generic;
using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] private List<GameObject> projectiles;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            foreach (var projectile in projectiles)
            {
                projectile.SetActive(true);
            }

            Destroy(gameObject);
        }
    }
}
