using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class Guard : MonoBehaviour
{
    private float elapsedTime = 30.0f;
    public bool isMaxVisionValues = false;

    public float moveSpeed = 5f; // Movement speed
    public float cooldownTime = 2.5f; // Cooldown time between movements

    private Vector3 targetPosition; // Target position for movement
    private float cooldownTimer; // Timer for cooldown between movements
    private bool isMoving = true; // Flag to indicate movement state
    public PolygonCollider2D pc;
    public logicScript logic;
    public RobberScript robber;

    Vector3 temp;
    void Start()
    {
        targetPosition = new Vector3(13f, 0f, 0f); // Initial target position
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicScript>();
        robber = GameObject.FindGameObjectWithTag("Robber").GetComponent<RobberScript>();
    }

    void Update()
    {
        temp = transform.localScale;
        elapsedTime -= Time.deltaTime;
        if (elapsedTime <= 0)
        {
            temp.x += 1.0f;
            temp.y += 0.5f;
            elapsedTime = 30.0f;

        }
        temp.x = Mathf.Min(temp.x, 15.0f);
        temp.y = Mathf.Min(temp.y, 8.5f);

        transform.localScale = temp;

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

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag("Robber")){
            logic.gameOver();
            robber.isAlive = false;
        }
    }
}