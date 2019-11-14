using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel1 : MonoBehaviour
{
    public GameObject LevelOne;
    public GameObject MinionBattle;
    public GameObject BeeBattle;
    public GameObject BossBattle;

    public void LoadMinionBattle()
    {
        LevelOne.SetActive(false);
        MinionBattle.SetActive(true);
    }

    public void LoadBeeBattle()
    {
        LevelOne.SetActive(false);
        BeeBattle.SetActive(true);
    }

    public void LoadLevelOne()
    {
        LevelOne.SetActive(true);
        MinionBattle.SetActive(false);
        BeeBattle.SetActive(false);
        BossBattle.SetActive(false);
    }

    public void LoadBossBattle()
    {
        LevelOne.SetActive(false);
        BossBattle.SetActive(true);
    }
}
