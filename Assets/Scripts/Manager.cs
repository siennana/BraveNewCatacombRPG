using UnityEngine;
using System.Collections;
using UnityEngine.UI; //Need this for calling UI scripts
using UnityEngine.SceneManagement;
public class Manager : MonoBehaviour
{
    //[SerializeField]
    //Transform UIPanel; //Will assign our panel to this variable so we can enable/disable it
    public GameObject pauseMenu;


    [SerializeField]
    bool isPaused; //Used to determine paused state

    void Start()
    {
        //UIPanel.gameObject.SetActive(false); //make sure our pause menu is disabled when scene starts
        //pauseMenu.SetActive(false);
        isPaused = false; //make sure isPaused is always false when our scene opens
    }
    void Update()
    {   //If player presses escape and game is not paused. Pause game.
        //If game is paused and player presses escape, unpause.
        if (Input.GetKeyDown(KeyCode.P) && !isPaused)
            Pause();
        else if (Input.GetKeyDown(KeyCode.P) && isPaused)
            UnPause();
    }
    public void Pause()
    {
        isPaused = true;
        //UIPanel.gameObject.SetActive(true); //turn on the pause menu
        pauseMenu.SetActive(true);
        Time.timeScale = 0f; //pause the game
    }
    public void UnPause()
    {
        isPaused = false;
        //UIPanel.gameObject.SetActive(false); //turn off pause menu
        pauseMenu.SetActive(false);
        Time.timeScale = 1f; //resume game
    }

    public void ReturnToMain()
    {
        SceneManager.LoadSceneAsync("StartMenu", LoadSceneMode.Single);
    }
    /*public void QuitGame()
    {
        Application.Quit();
    }
    public void Restart()
    {
        Application.LoadLevel(0);
    }
    */
}