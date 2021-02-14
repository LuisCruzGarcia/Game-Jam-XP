using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene : MonoBehaviour
{
    SceneLoader scene;

    private void Awake()
    {
        scene = FindObjectOfType<SceneLoader>();
    }

    public void loadFirstLevel()
    {
        scene.LoadFirstLevel();
    }

    public void QuitGame()
    {
        scene.QuitGame();
    }

    public void loadConfiguracion()
    {
        scene.LoadConfiguracion();
    }
}
