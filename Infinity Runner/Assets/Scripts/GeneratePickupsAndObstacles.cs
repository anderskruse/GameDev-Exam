using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePickupsAndObstacles : MonoBehaviour
{
    public Vector3 size;
    //public GameObject pickup;
    private Vector3 pos;
    public int amountOfpickups;
    public int amountOfObstacles;
    private ObjectPooler gop;
    private ObjectPooler oop;
    public GameObject gemPooler;
    public GameObject obstaclePooler;
    public PowerUp powerUp;

    void Awake()
    {
        gop = gemPooler.GetComponent<ObjectPooler>();
        oop = obstaclePooler.GetComponent<ObjectPooler>();
    }

    // Start is called before the first frame update
    void Start()
    {
        //amountOfObstacles = Random.Range(5, 15);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1,0,0, 0.3f);
        Gizmos.DrawCube(transform.position, size);
    }

    public void spawnPickups()
    {
        var gems = gemPooler.transform.GetComponentInChildren<Transform>();
        foreach (Transform gem in gems)
        {
            gem.gameObject.SetActive(false);
        }

        for (int i = 0; i < amountOfpickups; i++)
        {
            pos = new Vector3(Random.Range(-size.x / 2, size.x / 2) + transform.localPosition.x, 0, (transform.localPosition.z - (size.z / 2)) + i * (size.z / amountOfpickups));
            var myGem = gop.GetPooledObject();
            if (!myGem)
            {
                return;
            }
            
            //myGem.transform.position = new Vector3(0, 0, 0);
            //var myGemChildren = myGem.GetComponentsInChildren<Transform>();
            //for (int j = 0; j < myGemChildren.Length; i++)
            //{
            //    myGemChildren[j].position = new Vector3(0, 1, j * 2);
            //}


            myGem.transform.position = pos;
            myGem.SetActive(true);
        }
    }

    public void spawnObstacles()
    {
        var obstacles = obstaclePooler.transform.GetComponentInChildren<Transform>();
        foreach (Transform obstacle in obstacles)
        {
            obstacle.gameObject.SetActive(false);
        }

        for (int i = 0; i < amountOfObstacles; i++)
        {
            pos = new Vector3(Random.Range(-size.x / 2, size.x / 2) + transform.localPosition.x, 0, (size.z / amountOfObstacles) * (i + 1));
            var myObstacle = oop.GetPooledObject();
            if (!myObstacle)
            {
                return;
            }
            myObstacle.transform.position = pos;
            myObstacle.SetActive(true);

        }

        
    }

    public void spawnPowerUps()
    {
        pos = new Vector3(Random.Range(-size.x / 4, size.x / 4) + transform.localPosition.x, 0.5f, Random.Range(-size.z / 2 + transform.localPosition.z, transform.localPosition.z));
        powerUp.transform.position = pos;

    }
}
