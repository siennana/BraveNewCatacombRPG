using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerBattle : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    
    }

    private void OnTriggerEnter(Collider other)
    { 
        Debug.Log("Oh you're approaching me!");
        SceneManager.LoadScene("Battle", LoadSceneMode.Single);

        //Debug.Log("Scene2 loading: " + scenePaths[0]);
        //SceneManager.LoadScene(scenePaths[0], LoadSceneMode.Single);

    }
}
