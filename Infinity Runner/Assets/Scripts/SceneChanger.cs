using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void runCoroutine()
    {
        StartCoroutine(changeSceneCoroutine());
    }

    private IEnumerator changeSceneCoroutine()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(0);


    }
}
