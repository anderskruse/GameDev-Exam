using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{

    AudioSource audioSource;
    public AudioClip deathClip;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    private IEnumerator playDeathClip()
    {
        audioSource.PlayOneShot(deathClip);
        yield return null;
    }
}
