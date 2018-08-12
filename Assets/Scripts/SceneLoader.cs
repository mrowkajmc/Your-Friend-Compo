using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {
    private DataController dataController;

    void Start()
    {
        dataController = FindObjectOfType<DataController>();
    }
public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if  (currentSceneIndex == (SceneManager.sceneCount)+1) 
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            SceneManager.LoadScene(currentSceneIndex + 1);
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    public void Replay()
    {
        SceneManager.LoadScene("gameScene");
    }
    public void Win()
    {
        SceneManager.LoadScene("Win");
    }
    public void GoToEnd()
    {
        SceneManager.LoadScene("End");
    }
    public void GoToMain()
    {
        DataController.roundNumber = 0;
        SceneManager.LoadScene("persistent");
    }
    public void Lose()
    {
        SceneManager.LoadScene("Lose");
    }
    public void Continue()
    {
        if (DataController.roundNumber < 1)
        {
            SceneManager.LoadScene("gameScene");
            DataController.roundNumber += 1;
        }
        else
        {
            GoToEnd();
        }

    }
}
