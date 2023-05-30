using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderController : MonoBehaviour
{
    public GameObject objectToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Spawn Object is created for spawning the collection of colliders as object.
    void SpawnObject()
    {
        GameObject newObject = Instantiate(objectToSpawn);
    }
    void Update()
    {
        Invoke("SpawnObject", 2);
    }
}
