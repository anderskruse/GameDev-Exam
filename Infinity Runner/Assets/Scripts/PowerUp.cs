using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    private GameObject player;
    public float radius;
    public float pullForce;
    public bool activated;
    public float turnSpeed;

    void Start()
    {
        activated = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (activated)
        {
            Debug.Log("gameobject: " + gameObject);
            //gameObject.transform.RotateAround(player.transform.position, player.transform.up, 20 * Time.deltaTime);
            //gameObject.transform.position = new Vector3(player.transform.position.x - radius, 1, player.transform.position.z - radius);

        }
    }

    void LateUpdate()
    {
        if (activated)
        {
            transform.position = player.transform.position + (transform.position - player.transform.position).normalized * radius;
            transform.RotateAround(player.transform.position, new Vector3(0,1,0), turnSpeed * Time.deltaTime);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            activated = true;

        }
    }

    public void updatePlayerObject(GameObject player)
    {
        this.player = player;

    }

}
