using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;


    //movements
    Vector3 forward;
    Vector3 left;
    Vector3 right;

    void Start()
    {

    }

    void Update()
    {
        ////Get sounds from player
        //runSound = GetComponent<AudioSource>();
        //runSound.loop = true;
        //runSound.Play();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        forward = new Vector3(0f, 0f, speed * Time.fixedDeltaTime);
        left = new Vector3(-speed / 2 * Time.fixedDeltaTime, 0f, 0f);
        right = new Vector3(speed / 2 * Time.fixedDeltaTime, 0f, 0f);

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
        transform.Translate(forward);
        transform.rotation = Quaternion.LookRotation(forward);
    }

    private void TurnLeft()
    {
        transform.Translate(left, Space.World);
        transform.rotation = Quaternion.LookRotation(left + forward * 1.5f);
    }

    private void TurnRight()
    {
        transform.Translate(right, Space.World);
        transform.rotation = Quaternion.LookRotation(right + forward * 1.5f);
    }


}