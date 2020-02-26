using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadStartScene()
    {
        SceneManager.LoadScene(1);
    }
    public void ExitApplication()
    {
        Application.Quit();
    }
    public void LoadStartMenu()
    {
        SceneManager.LoadScene(0);
    }
}
