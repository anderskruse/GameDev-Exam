using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePickupsAndObstacles : MonoBehaviour
{
    public Vector3 size;
    public GameObject pickup;
    private Vector3 pos;
    public int amountOfpickups;
    

    // Start is called before the first frame update
    void Start()
    {
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
        print("hello");
        for (int i = 0; i < amountOfpickups; i++)
        {
            pos = new Vector3(Random.Range(-size.x / 2, size.x / 2) + transform.localPosition.x, 0, (size.z/amountOfpickups)*i);
            Instantiate(pickup, pos, Quaternion.identity); 
        }
    }
}
