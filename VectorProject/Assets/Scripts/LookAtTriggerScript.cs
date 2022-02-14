using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtTriggerScript : MonoBehaviour
{
    [Range(0f, 1f)]
    public float threshold = 0.5f;
    public float dotProduct = 0f;

    public Transform playerTransform;

    private void OnDrawGizmos()
    {
        Vector2 position = transform.position;
        Vector2 playerPosition = playerTransform.position;
        Vector2 playerLookDir = playerTransform.right;

        Vector2 playerToEnemyDir = (position - playerPosition).normalized;

        float lookingTowardsValue = Vector2.Dot(playerToEnemyDir, playerLookDir);
        dotProduct = lookingTowardsValue;

        bool canSeePlayer = lookingTowardsValue >= threshold;

        Gizmos.color = canSeePlayer ? Color.green : Color.red;
        Gizmos.DrawLine(position, playerPosition + playerToEnemyDir);

        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(playerPosition, playerPosition + playerLookDir);
    }
}
