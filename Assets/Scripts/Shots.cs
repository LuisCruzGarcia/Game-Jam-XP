using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shots : MonoBehaviour
{
    public Rigidbody2D proyectile;
    public float timeRemaining = 6;

    private void Start()
    {
        proyectile = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if(timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            proyectile.position += new Vector2(Random.Range(-5, 6), Random.Range(-5, 6)) * Time.deltaTime;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
