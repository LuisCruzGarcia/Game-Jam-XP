using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victory : MonoBehaviour
{

    SceneLoader scene;
    // Start is called before the first frame update

    private void Awake()
    {
        scene = FindObjectOfType<SceneLoader>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            scene.LoadNextScene();
        }
    }
}
