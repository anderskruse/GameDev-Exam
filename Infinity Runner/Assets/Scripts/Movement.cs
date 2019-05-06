using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;

    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        player.transform.Translate(0f, 0f, 8f * Time.deltaTime);

        if (Input.GetKey(KeyCode.A))
        {
            player.transform.Translate(-8f * Time.deltaTime, 0f, 0f);

        }
        else if (Input.GetKey(KeyCode.D))
        {
            player.transform.Translate(8f * Time.deltaTime, 0f, 0f);

        }

    }
}
