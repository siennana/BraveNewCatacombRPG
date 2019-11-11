using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleScript : MonoBehaviour
{
    public GameObject attackMenu;

    public void getAttackMenu()
    {
        this.gameObject.SetActive(false);
        attackMenu.SetActive(true);
    }
}
