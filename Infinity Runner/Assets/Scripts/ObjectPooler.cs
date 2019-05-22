using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    // public static ObjectPooler current;
    public GameObject pooledObject;
    public Transform container;
    public int pooledAmount;
    public bool willGrow;

    List<GameObject> pooledObjects;

    void Awake()
    {
        pooledObjects = new List<GameObject>();
        for (int i = 0; i < pooledAmount; i++)
        {
            pooledObjects.Add(Instantiate(pooledObject));
            pooledObjects[i].SetActive(false);
            pooledObjects[i].transform.SetParent(container);
        }
    }

    public GameObject GetPooledObject()
    {
        for (int i = 0; i < pooledObjects.Count; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }

        if (willGrow)
        {
            GameObject obj = Instantiate(pooledObject);
            obj.transform.SetParent(container);
            pooledObjects.Add(obj);
            return obj;
        }

        return null;
    }
}