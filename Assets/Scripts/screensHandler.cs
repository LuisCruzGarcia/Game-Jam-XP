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
    Scene scene;
    void Start()
    {
        instructions = GameObject.Find("instructions");
        gameOver = GameObject.Find("GameOver");

       
        


        gameOver.SetActive(false);

        


        

    }

    private void Update()
    {
        scene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame

    public void GameOver()
    {
        gameOver.SetActive(true);
        instructions.SetActive(false);

    }

    void reloadScene()
    {
        Debug.Log("patata");
        SceneManager.LoadScene(scene.name);
    }


    


}
