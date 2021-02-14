using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCuarta : MonoBehaviour
{
    private void Start()
    {
        FindObjectOfType<AudioManager>().Play("Intro maligno");
    }
}
