using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public int currentScene;
    public static SceneLoader Instance;
    public int puntuacion;
    public GameObject UIPuntuacion;
    public Text uiPuntuacionText;

   
    void Awake()
    {
        this.InstantiateController();
        currentScene = SceneManager.GetActiveScene().buildIndex;
    }

    private void InstantiateController()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
        else if (this != Instance)
        {
            Destroy(this.gameObject);
        }
    }

    public int GetScene()
    {
        return currentScene;
    }

    public void LoadNextScene()
    {
        currentScene++;
        if (FindObjectOfType<AudioManager>())
        {
            FindObjectOfType<AudioManager>().Stop("bodega");
            FindObjectOfType<AudioManager>().Stop("Garage");
            FindObjectOfType<AudioManager>().Stop("Intro");
            FindObjectOfType<AudioManager>().Stop("Intro maligno");
            FindObjectOfType<AudioManager>().Stop("Intro alto");
        }
        SceneManager.LoadScene(currentScene);
    }

    public void SubirPuntuacion(int nuevosPuntos)
    {
        puntuacion += nuevosPuntos;
    }

    public void LoadLoseScene()
    {
        SceneManager.LoadScene("Lose Screen");
    }

    public void LoadFirstLevel()
    {
        SceneManager.LoadScene("First Scene");
    }

    public void LoadConfiguracion()
    {
        SceneManager.LoadScene("Controles");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
