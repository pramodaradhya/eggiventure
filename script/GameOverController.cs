using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverController : MonoBehaviour
{
    public Button buttonRestart;
    public Button buttonExit;
    public bool gameHasEnded = false;
    public float restartDelay = 255555f;

    private void Awake()
    {
        if (GameObject.FindWithTag("RestartButton"))
        {
            buttonRestart.onClick.AddListener(RestartLevel);
        }
     /*   if (GameObject.FindWithTag("ExitButton"))
        {

            buttonExit.onClick.AddListener(ExitLevel);
        }
*/
    }

    public void EndGame()
    {
        //if(gameHasEnded == false)
        //{
        //gameHasEnded == true;
        Invoke("PlayerDied", restartDelay);
        //}
    }
    public void PlayerDied()
    {
        gameObject.SetActive(true);
    }
    public void RestartLevel() //Restarts the level
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ExitLevel() //Restarts the level
    {

        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Application.Quit();
    }
}
