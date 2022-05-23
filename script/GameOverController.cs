using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverController : MonoBehaviour
{
    public Button buttonRestart;
    public Button buttonExit;
    public PlaySound playSound;
    
    
    //public PlayerHealth playerHealth;
    private void Awake()
    {
        
        if (GameObject.FindWithTag("RestartButton"))
        {
            buttonRestart.onClick.AddListener(RestartLevel);
        }
        if (GameObject.FindWithTag("ExitButton"))
        {

            buttonExit.onClick.AddListener(ExitLevel);
        }
    }

  
    public void PlayerDied()
    {
        gameObject.SetActive(true);


    }
    
    public void RestartLevel() //Restarts the level
    {
        SceneManager.LoadScene(0);
    }

    public void ExitLevel() //Restarts the level
    {

        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Application.Quit();
    }
}
