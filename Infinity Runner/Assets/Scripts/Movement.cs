using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 8f;

    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, 0f, speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-8f * Time.deltaTime, 0f, 0f);

        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(8f * Time.deltaTime, 0f, 0f);

        }

    }
}
