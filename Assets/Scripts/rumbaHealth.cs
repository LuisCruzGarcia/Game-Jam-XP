using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rumbaHealth : MonoBehaviour
{

    public int health = 3; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (health < 1)
        {
            GameObject.Find("Screens").GetComponent<screensHandler>().GameOver();
            Destroy(gameObject);
        }


    }
}
