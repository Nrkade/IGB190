using UnityEngine;

public class TrapWallPush : MonoBehaviour
{
    public float pushDistance = 1f; // Distance to push the player away from the wall

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Ensure the collider is the player
        {
            Debug.Log("Player is colliding");
            // Calculate the direction to push the player away from the wall
            Vector3 pushDirection = (other.transform.position - transform.position).normalized;

            // Calculate the new position for the player
            Vector3 newPosition = other.transform.position + pushDirection * pushDistance;

            // Move the player to the new position
            other.transform.position = newPosition;

            Debug.Log("Player has been moved back");
        }
    }
}
