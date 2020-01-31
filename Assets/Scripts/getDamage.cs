using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class getDamage : MonoBehaviour
{
    public GameObject mainScreen;
    public Slider Health;
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
    public void RunToBe()
    {
        StartCoroutine(ToBeCont());
    }
    public void RunWin()
    {
        StartCoroutine(WinRoutine());
    }

    private IEnumerator WinRoutine()
    {
        Health.value = 0f;
        yield return new WaitForSeconds(1.5f);
        battle.SetActive(false);
        mainScreen.SetActive(true);
    }
    private IEnumerator ToBeCont()
    {
        Health.value = 0f;
        yield return new WaitForSeconds(1f);
        battle.SetActive(false);
        LoadingScreen.SetActive(true);
    }
    private IEnumerator LoadAsynchronously()
    {
        Health.value = 0f;
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
