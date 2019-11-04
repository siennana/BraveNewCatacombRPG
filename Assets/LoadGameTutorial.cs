using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGameTutorial : MonoBehaviour
{
    public void LoadTutorial()
    {
        SceneManager.LoadScene("TerrainPractice", LoadSceneMode.Single);
    }
}
