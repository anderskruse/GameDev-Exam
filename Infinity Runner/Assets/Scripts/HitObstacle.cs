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

            sc.runCoroutine();
            gameObject.SetActive(false);
            statusMessage.text = "GAME OVER";
        } 
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Terrain")
        {
            Debug.Log("Terrain");
            sc.runCoroutine();
            gameObject.SetActive(false);
            statusMessage.text = "GAME OVER";
        }
    }

    //private void OnCollisionExit(Collision collision)
    //{
    //    if (collision.gameObject.name == "Terrain")
    //    {
    //        StartCoroutine(awayFromTerrain());
    //    }
    //}

    //private IEnumerator awayFromTerrain()
    //{
    //    if(Physics.Raycast(transform.position, Vector3.down, out RaycastHit hit, ~lm))
    //    {
    //        Debug.Log("Terrain");
    //        sc.runCoroutine();
    //        gameObject.SetActive(false);
    //        statusMessage.text = "GAME OVER";
    //    }
    //    yield return new WaitForSeconds(1f);

    //}
    
}
