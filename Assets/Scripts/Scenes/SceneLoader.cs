using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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

    private void Update()
    {
        UIPuntuacion = GameObject.Find("UIPuntuacion");
        uiPuntuacionText = UIPuntuacion.GetComponent<Text>();
        uiPuntuacionText.text = puntuacion.ToString();
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

    public void LoadNextScene()
    {
        currentScene++;
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

    public void QuitGame()
    {
        Application.Quit();
    }
}
