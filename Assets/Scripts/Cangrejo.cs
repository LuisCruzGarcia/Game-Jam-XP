using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cangrejo : MonoBehaviour
{
    public GameObject Proyectile;
    public float timeRemaining = 3;

    // Update is called once per frame
    void Update()
    {
        if(timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;  
        }
        else
        {
            Instantiate(Proyectile, transform.position, transform.rotation);
            Instantiate(Proyectile, transform.position, transform.rotation);
            Instantiate(Proyectile, transform.position, transform.rotation);
            timeRemaining = 3;
        }
    }
}
