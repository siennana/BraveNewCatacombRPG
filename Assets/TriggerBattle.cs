using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerBattle : MonoBehaviour
{
    public GameObject BattleObject;
    public GameObject Tutorial;

    private void OnTriggerEnter(Collider other)
    { 
        Debug.Log("Oh you're approaching me!");
       
        Tutorial.SetActive(false);
        BattleObject.SetActive(true);
    }
}
