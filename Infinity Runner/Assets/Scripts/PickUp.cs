using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public PowerUp powerUp;
    private UpdateScore score;
    private GameObject player;

    void Start()
    {
        powerUp = GameObject.FindGameObjectWithTag("PowerUp").GetComponent<PowerUp>();
        score = GameObject.Find("GameController").GetComponent<UpdateScore>();
    }

    // Update is called once per frame
    void Update()
    {   
        //Create a manget pulling effect towards Player if magnet power up is activated
        if (powerUp.activated && Vector3.Distance(transform.position, GameObject.FindGameObjectWithTag("Player").transform.position) < 5)
        {
            transform.position = Vector3.MoveTowards(transform.position, GameObject.FindGameObjectWithTag("Player").transform.position, Time.deltaTime * 10);
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);

            score.incrementScore();

        }
    }


}

