using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMove : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed;

    //movements
    Vector3 forward;
    Vector3 left;
    Vector3 right;

    void Start()
    {
        speed = Random.Range(5, 15);
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        forward = new Vector3(0f, 0f, speed * Time.fixedDeltaTime);

        MoveForward();
    }

    private void MoveForward()
    {
        transform.Translate(forward);
        transform.rotation = Quaternion.LookRotation(forward);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ChangeLevel")
        {
            gameObject.SetActive(false);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Terrain")
        {
            gameObject.SetActive(false);
        }
    }


}