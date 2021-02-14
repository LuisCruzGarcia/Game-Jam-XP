using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControles : MonoBehaviour
{
    private void Start()
    {
        FindObjectOfType<AudioManager>().Play("Intro");
    }
}
