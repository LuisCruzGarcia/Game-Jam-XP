using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtomizadorSniper : MonoBehaviour
{
    public float timer;
    public GameObject prefab;

    private void Update()
    {
        if(timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            Instantiate(prefab, transform.position, transform.rotation);
            timer = 12;
        }
    }
}
