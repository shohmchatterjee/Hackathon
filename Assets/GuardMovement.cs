 using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class GuardMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Movement speed
    public float cooldownTime = 2.5f; // Cooldown time between movements

    private Vector3 targetPosition; // Target position for movement
    private float cooldownTimer; // Timer for cooldown between movements
    private bool isMoving = true; // Flag to indicate movement state
    public PolygonCollider2D pc;

    void Start()
    {
        targetPosition = new Vector3(13f, 0f, 0f); // Initial target position
        pc = GetComponent<PolygonCollider2D>();
    }

    void Update()
    {
        if (isMoving)
        {
            MoveTowardsTarget();

        }
        else
        {
            // Cooldown in progress
            cooldownTimer -= Time.deltaTime;
            if (cooldownTimer <= 0.0f)
            {
                // Cooldown finished, switch target and start moving
                isMoving = true;
                targetPosition = targetPosition == new Vector3(13f, 0f, 0f) ? new Vector3(-13f, 0f, 0f) : new Vector3(13f, 0f, 0f);
                cooldownTimer = cooldownTime; // Set fixed cooldown
            }
        }
    }

    void MoveTowardsTarget()
    {
        // Use Vector3.MoveTowards with a slightly smaller distance than target
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime * 0.95f);

        // Check if reached target (within a small tolerance)
        if (Mathf.Abs(transform.position.x - targetPosition.x) < 0.1f)
        {
            isMoving = false; // Stop movement and start cooldown
        }
    }
}
