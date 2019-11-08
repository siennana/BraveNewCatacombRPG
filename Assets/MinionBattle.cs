using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MinionBattle : MonoBehaviour
{
    public GameObject minionScene;
    public GameObject LevelOne;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Oh you're approaching me!");
        LevelOne.SetActive(false);
        minionScene.SetActive(true);
    }
}
