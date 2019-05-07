using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawns : MonoBehaviour
{
    public Transform spawnpointDesert;
    public Transform spawnpointForest;
    public GameObject camel;
    public GameObject horse;


    void Start()
    {
        Instantiate(camel, spawnpointDesert.transform.position, Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
