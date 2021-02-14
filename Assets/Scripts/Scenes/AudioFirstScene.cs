using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioFirstScene : MonoBehaviour
{
    private void Start()
    {
        FindObjectOfType<AudioManager>().Play("Intro");
    }
}
