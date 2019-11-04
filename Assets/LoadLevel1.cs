using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel1 : MonoBehaviour
{
    public void LoadNextLevel()
    {
        SceneManager.LoadScene("Level 1", LoadSceneMode.Single);
    }
}
