using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public GameObject player;
    public GameObject cam;

    private Vector3 offset;

    void Start()
    {
        offset = cam.transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        cam.transform.position = player.transform.position + offset;
    }

    void updatePlayerObject()
    {

    }
}

