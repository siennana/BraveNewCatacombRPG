using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGameTutorial : MonoBehaviour
{
    [SerializeField]
    AudioSource btnAudio;
    public void LoadTutorial()
    {
        //btnAudio.Play();
        _ = SceneManager.LoadSceneAsync("TerrainPractice", LoadSceneMode.Single);
    }
}
