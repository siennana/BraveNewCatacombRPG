using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadCredits : MonoBehaviour
{
    public GameObject mainMenu;

    public void LoadCreditScreen()
    {
        mainMenu.SetActive(false);
        this.gameObject.SetActive(true);
    }

    public void LoadMainScreen()
    {
        mainMenu.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
