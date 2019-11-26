using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadGameTutorial : MonoBehaviour
{
    [SerializeField]
    AudioSource btnAudio;
    public GameObject LoadingScreen;
    public Slider slider;
    public Text progressText;
    public GameObject MainMenu;

    //initiates loading screen and main menu
    public void LoadTutorial()
    {
        //btnAudio.Play();
        LoadingScreen.SetActive(true);
        MainMenu.SetActive(false);
        StartCoroutine(LoadAsynchronously());
        
    }

    private IEnumerator LoadAsynchronously()
    {

        AsyncOperation operation = SceneManager.LoadSceneAsync("GameTutorial", LoadSceneMode.Single);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);

            slider.value = progress;
            progressText.text = (progress * 100f).ToString("n2") + "%";
            Debug.Log(operation.progress);

            yield return null;
        }
    }
}
