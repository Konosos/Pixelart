using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change_Scene : MonoBehaviour
{
    public void Load_Scene(string _loadScene)
    {
        SceneManager.LoadScene(_loadScene);
    }
    public void Quit()
    {
        Application.Quit();
    }
}

