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
            pos = new Vector3(Random.Range(-size.x / 2, size.x / 2) + transform.localPosition.x, 0, (size.z/amountOfpickups)*i);
            var myGem = gop.GetPooledObject();
            if (!myGem)
            {
                return;
            }
            myGem.transform.position = pos;
            myGem.SetActive(true);

        }
        spawnObstacles();
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
            pos = new Vector3(Random.Range(-size.x / 2, size.x / 2) + transform.localPosition.x, 0, (size.z / amountOfObstacles+ 10) * i);
            var myObstacle = oop.GetPooledObject();
            if (!myObstacle)
            {
                return;
            }
            myObstacle.transform.position = pos;
            myObstacle.SetActive(true);

        }
    }
}
