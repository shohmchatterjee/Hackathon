using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextLevelScript : MonoBehaviour
{
    public GameObject robber;
    public bool nextLevel;
    public logicScript logic;
    // Start is called before the first frame update
    void Start()
    {
        nextLevel = false;
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision){
        nextLevel = true;
        logic.nextLevel();
        nextLevel = false;
    }
}
