using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private UpdateScore score;
    void Start()
    {
        score = GameObject.Find("GameController").GetComponent<UpdateScore>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);

            score.incrementScore();
            
        }
    }

}
