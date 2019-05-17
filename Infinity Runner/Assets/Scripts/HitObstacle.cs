using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class HitObstacle : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI statusMessage;

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
            gameObject.SetActive(false);
            statusMessage.text = "GAME OVER";
            StartCoroutine(changeSceneCoroutine());
        } 
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Terrain")
        {
            gameObject.SetActive(false);
            statusMessage.text = "GAME OVER";
            StartCoroutine(changeSceneCoroutine());
        }
    }

    private IEnumerator changeSceneCoroutine()
    {
        print("hello");
        yield return new WaitForSeconds(5);
        print("hello2");
        SceneManager.LoadScene(0);
        
        
    }

    private void changeScene()
    {
        print("Hello3");
        SceneManager.LoadScene("Main Menu");
    }
}
