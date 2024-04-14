using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobberScript : MonoBehaviour
{
    public float moveSpeed;
    private float horizontal;
    private float vertical;
    

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        Vector2 movement = new Vector2(horizontal, vertical);
        movement = movement.normalized * moveSpeed * Time.deltaTime;

        transform.Translate(movement * Time.deltaTime);
    }
}