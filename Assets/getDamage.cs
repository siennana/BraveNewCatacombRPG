using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class getDamage : MonoBehaviour
{
    public Slider playerHealth;
    public GameObject battle;
    public GameObject LoadingScreen;
    public Slider progressSlider;
    public Text progressText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void RunProcess()
    {
        StartCoroutine(LoadAsynchronously());
    }

    private IEnumerator LoadAsynchronously()
    {
        playerHealth.value = 0f;
        yield return new WaitForSeconds(1);
        AsyncOperation operation = SceneManager.LoadSceneAsync("Level 1", LoadSceneMode.Single);
        battle.SetActive(false);
        LoadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);

            progressSlider.value = progress;
            progressText.text = (progress * 100f).ToString("n2") + "%";
            Debug.Log(operation.progress);

            yield return null;
        }
    }
}
