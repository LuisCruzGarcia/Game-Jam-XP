using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logo : MonoBehaviour
{
    SceneLoader scene;

    private void Awake()
    {
        scene = FindObjectOfType<SceneLoader>();
    }

    private void Start()
    {
        StartCoroutine(Wait());
    }

    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(5f);
        scene.LoadNextScene();
    }
}
