using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnExitDoor : MonoBehaviour
{

    public GameObject door;
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
            Instantiate(door, transform.position, transform.rotation);
            nextLevel = false;
        }
    }
}
