using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class screensHandler : MonoBehaviour
{
    // Start is called before the first frame update

    GameObject instructions, gameOver;
    Button menu;
    Button reload;

    public SceneLoader scene;

    void Start()
    {
        instructions = GameObject.Find("instructions");
        gameOver = GameObject.Find("GameOver");

        menu = GameObject.Find("menu").GetComponent<Button>();
        menu.onClick.AddListener(loadMenu);
        reload = GameObject.Find("reload").GetComponent<Button>();
        reload.onClick.AddListener(reloadScene);

        gameOver.SetActive(false);

        scene = FindObjectOfType<SceneLoader>();
    }

    // Update is called once per frame

    public void GameOver()
    {
        gameOver.SetActive(true);
        instructions.SetActive(false);

    }

    void reloadScene()
    {
        
        SceneManager.LoadScene(scene.GetScene());
    }

    void loadMenu()
    {
        SceneManager.LoadScene(1);
    }


    


}
