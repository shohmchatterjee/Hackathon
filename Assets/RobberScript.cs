using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobberScript : MonoBehaviour
{
    public float moveSpeed;
    public bool isAlive = true;
    private float horizontal;
    private float vertical;
    
    void Start(){
        
    }
    void Update()
    {
        if(isAlive){
            horizontal = Input.GetAxisRaw("Horizontal");
            vertical = Input.GetAxisRaw("Vertical");

            Vector2 movement = new Vector2(horizontal, vertical);
            movement = movement.normalized * moveSpeed * Time.deltaTime;

            transform.Translate(movement * Time.deltaTime);
        }
    }
}