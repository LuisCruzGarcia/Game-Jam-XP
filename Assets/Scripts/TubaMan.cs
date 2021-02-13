using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubaMan : MonoBehaviour
{
    public float timer;
    public GameObject wave;

    // Update is called once per frame
    void Update()
    {
        if(timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            Instantiate(wave, transform.position, transform.rotation);
            timer = 10;
        }
    }
}
