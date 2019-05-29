using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{

    public AudioClip[] deathClips;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void playDeathClip(GameObject player)
    {
        switch (player.name)
        {
            case "Camel":
                AudioSource.PlayClipAtPoint(deathClips[0], player.transform.position, 1f);
                break;

            case "Horse":
                AudioSource.PlayClipAtPoint(deathClips[1], player.transform.position, 1f);
                break;

            case "Penguin":
                AudioSource.PlayClipAtPoint(deathClips[2], player.transform.position, 1f);
                break;

            default:
                break;
        }

    }
}
