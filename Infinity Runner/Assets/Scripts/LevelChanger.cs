using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelChanger : MonoBehaviour
{

    public GameObject[] environments;

    void Start()
    {
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

        yield return null;
    }
}
