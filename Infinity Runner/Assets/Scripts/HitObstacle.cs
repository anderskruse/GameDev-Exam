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
    public SoundController soundController;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Obstacle")
        {
            soundController.playDeathClip(gameObject);
            sc.runCoroutine();
            gameObject.SetActive(false);
            statusMessage.text = "GAME OVER";
        } 
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Terrain")
        {
            soundController.playDeathClip(gameObject);
            Debug.Log("Terrain");
            sc.runCoroutine();
            gameObject.SetActive(false);
            statusMessage.text = "GAME OVER";
        }
    }
    
}
