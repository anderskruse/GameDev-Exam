using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnEnableGems : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnEnable()
    {
        Transform[] transforms = GetComponentsInChildren<Transform>(true);
        foreach (Transform t in transforms)
        {
            t.gameObject.SetActive(true);
        }
    }
}
