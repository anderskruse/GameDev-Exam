using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;

    //movements
    Vector3 forward;
    Vector3 left;
    Vector3 right;

    void Start()
    {
        forward = new Vector3(0f, 0f, 8f * Time.deltaTime);
        left = new Vector3(-8f * Time.deltaTime, 0f, 0f);
        right = new Vector3(8f * Time.deltaTime, 0f, 0f);


    }


    // Update is called once per frame
    void FixedUpdate()
    {

        MoveForward();
        if (Input.GetKey(KeyCode.A))
        {
            TurnLeft();
        }
        else if (Input.GetKey(KeyCode.D))
        {
            TurnRight();
        }

    }

    private void MoveForward()
    {
        player.transform.Translate(forward);
        player.transform.rotation = Quaternion.LookRotation(forward);
    }

    private void TurnLeft()
    {
        player.transform.Translate(left, Space.World);
        player.transform.rotation = Quaternion.LookRotation(left + forward * 2);
    }

    private void TurnRight()
    {
        player.transform.Translate(right, Space.World);
        player.transform.rotation = Quaternion.LookRotation(right + forward * 2);
    }

}