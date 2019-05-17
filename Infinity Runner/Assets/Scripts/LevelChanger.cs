using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelChanger : MonoBehaviour
{

    public GameObject[] environments;
    private UpdateScore score;
    public float scoreSpeed;
    float multiplier = 1.2f;
    


    void Start()
    {
        StartCoroutine(addToScore());
        score = GetComponent<UpdateScore>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartRandomLevel()
    {
        StartCoroutine(RandomLevel());
    }


    public IEnumerator RandomLevel()
    {
        //Make random number based on the amounts of environments
        int rand = Random.Range(0, environments.Length);

        //Enable environment based on the random number
        while (environments[rand].gameObject.activeSelf)
        {
            rand = Random.Range(0, environments.Length);
        }
        environments[rand].gameObject.SetActive(true);



        //Swap camera to new animal
        GameObject player = environments[rand].gameObject.transform.GetChild(0).gameObject;
        GetComponent<PlayerCamera>().updatePlayerObject(player);


        //amount to increment the score with each time a level is loaded
        scoreSpeed *= multiplier;

        ////Increment player speed after each reload
        player.GetComponent<Movement>().speed *= multiplier;


        yield return null;
    }

    private IEnumerator addToScore()
    {
        //increments the score corresponding to speed
        yield return new WaitForSeconds(0.5f);
        score.incrementScore((int)scoreSpeed);
        StartCoroutine(addToScore());

    }

    public void startAddToScore()
    {
        StartCoroutine(addToScore());
    }

    
}
