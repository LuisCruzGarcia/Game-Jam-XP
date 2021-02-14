using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioThirdScene : MonoBehaviour
{
    private void Start()
    {
        FindObjectOfType<AudioManager>().Play("Intro alto");
    }
}
