using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//EXIT DOOR
public class DoorScript : MonoBehaviour
{
    public VaultItemScript vault;
    public GameObject door;
    // Start is called before the first frame update
    void Start()
    {
        vault = GameObject.FindGameObjectWithTag("vault").GetComponent<VaultItemScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision){
        if(vault.hasVaultItem){
            Destroy(door);
        }
    }
}
