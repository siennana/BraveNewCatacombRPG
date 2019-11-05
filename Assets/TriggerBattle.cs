using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerBattle : MonoBehaviour
{
    private AssetBundle myLoadedAssetBundle;
    private string[] scenePaths;
    public Camera playerCamera;
    public Camera battleCamera;

    // Use this for initialization
    void Start()
    {
        //myLoadedAssetBundle = AssetBundle.LoadFromFile("Assets/");
        //scenePaths = myLoadedAssetBundle.GetAllScenePaths();
    
    }

    private void OnTriggerEnter(Collider other)
    { 
        Debug.Log("Oh you're approaching me!");
        //Debug.Log("Scene2 loading: " + scenePaths[0]);
        //SceneManager.LoadScene(scenePaths[0], LoadSceneMode.Single);

    }
}
