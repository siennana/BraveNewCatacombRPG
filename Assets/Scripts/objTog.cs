using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class objTog : MonoBehaviour
{
    // UI elements to toggle on / off
    [SerializeField]
    public GameObject textbox;
    public GameObject dialogue;
    public GameObject name;

    void Start()
    {
        textbox.SetActive(false);
        dialogue.SetActive(false);
        name.SetActive(false);
    }

    // Makes objects visble
    void turnOn()
    {
        textbox.SetActive(true);
        dialogue.SetActive(true);
        name.SetActive(true);
    }

    // Makes objects invisible
    void turnOff()
    {
        textbox.SetActive(false);
        dialogue.SetActive(false);
        name.SetActive(false);
    }

}
