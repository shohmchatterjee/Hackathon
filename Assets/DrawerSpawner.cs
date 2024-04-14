using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerSpawner : MonoBehaviour
{
    public GameObject drawer;
    bool nextLevel;
    
    // Start is called before the first frame update
    void Start()
    {
        nextLevel = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (nextLevel)
        {
            transform.position = Random.insideUnitCircle * 50;
            Instantiate(drawer, transform.position, transform.rotation);
            transform.position = Random.insideUnitCircle * 50;
            Instantiate(drawer, transform.position, transform.rotation);
            nextLevel = false;
        }
    }
}
