using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BeeBattle : MonoBehaviour
{
    public Slider Health;
    public GameObject LevelOne;
    public GameObject beeBattle;
    public GameObject menuItems;
    public GameObject attackItems;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        LevelOne.SetActive(false);
        beeBattle.SetActive(true);
        this.gameObject.SetActive(false);
        Health.value = 1f;
        attackItems.SetActive(false);
        menuItems.SetActive(true);
    }

}
