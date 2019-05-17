using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    private GameObject player;
    //public Transform target;
    public GameObject cam;
    Vector3 customOffset;

    private Vector3 offset;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        offset = new Vector3(0, 2.7f, -3.3f);
    }

    void LateUpdate()
    {
        if (player)
        {
            cam.transform.position = player.transform.position + offset + customOffset;

        }
    }


    public void updatePlayerObject(GameObject player)
    {
        this.player = player;
        switch (player.gameObject.name)
        {
            case "Penguin":
                customOffset = new Vector3(0f, -1f, 0f);
                break;

            default:
                customOffset = new Vector3(0f, 0f, 0f);
                break;
        }

    }
}

