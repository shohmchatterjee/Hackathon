using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerScript : MonoBehaviour
{
    public logicScript logic;
    public GameObject gold;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicScript>();
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D collision)
    {
        logic.Score();
        DestroyObject(gold);
    }
}
