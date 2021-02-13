using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screensHandler : MonoBehaviour
{
    // Start is called before the first frame update

    GameObject instructions, gameOver;
    void Start()
    {
        instructions = GameObject.Find("instructions");
        gameOver = GameObject.Find("GameOver");

        
        gameOver.SetActive(false);
            
    }

    // Update is called once per frame
    
    public void GameOver()
    {
        gameOver.SetActive(true);
        instructions.SetActive(false);

    }


}
