using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class HitObstacle : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI statusMessage;
    public SceneChanger sc;
    public LayerMask lm;
    AudioSource audioSource;
    public AudioClip deathClip;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Obstacle")
        {

            audioSource.PlayOneShot(deathClip);
            sc.runCoroutine();
            gameObject.SetActive(false);
            statusMessage.text = "GAME OVER";
        } 
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Terrain")
        {
            audioSource.PlayOneShot(deathClip);
            Debug.Log("Terrain");
            sc.runCoroutine();
            gameObject.SetActive(false);
            statusMessage.text = "GAME OVER";
        }
    }
    
}
