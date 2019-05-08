using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalCollision : MonoBehaviour
{
    public LevelChanger lc;
    public GameObject spawnpoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        
        if (other.gameObject.tag == "Player")
        {
            //Enable random environment and animal
            lc.StartRandomLevel();

            //Reset the last playing animal's position back to spawnpoint
            other.gameObject.transform.position = spawnpoint.transform.position;

            //Disable current environment
            transform.parent.gameObject.SetActive(false);
        }
    }
}
