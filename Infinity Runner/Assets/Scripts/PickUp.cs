using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private PowerUp powerUp;
    private UpdateScore score;
    private GameObject player;
    public int range;
    public int pullForce;

    void Start()
    {
        powerUp = GameObject.FindGameObjectWithTag("PowerUp").GetComponent<PowerUp>();
        score = GameObject.Find("GameController").GetComponent<UpdateScore>();
    }

    // Update is called once per frame
    void Update()
    {   
        //Create a manget pulling effect towards Player if magnet power up is activated
        if (powerUp.activated && Vector3.Distance(transform.position, GameObject.FindGameObjectWithTag("Player").transform.position) < range)
        {
            transform.position = Vector3.MoveTowards(transform.position, GameObject.FindGameObjectWithTag("Player").transform.position, Time.deltaTime * pullForce);
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if(score == null)
        {
            score = GameObject.Find("GameController").GetComponent<UpdateScore>();
        }
        if (collider.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);

            score.incrementScore();

        }
    }


}

