using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class getDamage : MonoBehaviour
{
    public GameObject mainScreen;
    public Slider PlayerHealth;
    public Slider EnemyHealth;
    public GameObject battle;
    public GameObject LoadingScreen;
    public Slider progressSlider;
    public Text progressText;
    public Button SpecialAttack;

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

    public void DmgEnemy(float mult)
    {
        var damage = Random.Range(0f, 0.35f) * mult;
        if (EnemyHealth.value - damage > 0f) {
            EnemyHealth.value -= damage;
        }
        else if(EnemyHealth.value - damage <= 0f)
        {
            EnemyHealth.value = 0f;
            StartCoroutine(WinRoutine());
        }

    }
    public void DmgPlayer()
    {
        var damage = Random.Range(0.2f, 0.35f);
        if (PlayerHealth.value-damage > 0f)
        {
            PlayerHealth.value -= damage;
        }
        else if(PlayerHealth.value - damage <= 0f)
        {
            PlayerHealth.value = 0f;
        }

        if(PlayerHealth.value <= 0.35f)
        {
            SpecialAttack.interactable = true;
            SpecialAttack.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = "Special";
        }


    }

    public void HealPlayer()
    {
        if (PlayerHealth.value > 0.75f)
        {
            PlayerHealth.value = 1f;
        }
        else
        {
            PlayerHealth.value += 0.25f;
        }
    }

    private IEnumerator SubDmgEnemy()
    {
        yield return new WaitForSeconds(1.5f);
        EnemyHealth.value -= Random.Range(0f, 0.25f); ;
    }
    private IEnumerator SubDmgPlayer()
    {
        yield return new WaitForSeconds(1.5f);
        PlayerHealth.value -= Random.Range(0f, 0.25f);
    }
    private IEnumerator SubHealPlayer()
    {
        yield return new WaitForSeconds(1.5f);
        if (PlayerHealth.value > 0.75f)
        {
            PlayerHealth.value = 1f;
        }
        else
        {
            PlayerHealth.value += 0.25f;
        }
    }
    private IEnumerator WinRoutine()
    {
        EnemyHealth.value = 0f;
        yield return new WaitForSeconds(1.5f);
        PlayerHealth.value = 1f;
        battle.SetActive(false);
        mainScreen.SetActive(true);
    }
    private IEnumerator ToBeCont()
    {
        EnemyHealth.value = 0f;
        yield return new WaitForSeconds(1f);
        battle.SetActive(false);
        LoadingScreen.SetActive(true);
    }
    private IEnumerator LoadAsynchronously()
    {
        EnemyHealth.value = 0f;
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
