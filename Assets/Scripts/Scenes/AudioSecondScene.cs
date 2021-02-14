using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSecondScene : MonoBehaviour
{
    private void Start()
    {
        FindObjectOfType<AudioManager>().Play("bodega");
    }
}
