using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeeBattle : MonoBehaviour
{
    public GameObject LevelOne;
    public GameObject beeBattle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Oh you're approaching me!");
        LevelOne.SetActive(false);
        beeBattle.SetActive(true);
    }
}
