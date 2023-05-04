using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadManager : MonoBehaviour
{
    public void QuitApp()
    {
        Application.Quit();
    }

    public void LoadNewScene(int newSceneIndex)
    {
        SceneManager.LoadScene(newSceneIndex);
    }
}
