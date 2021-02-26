using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletRumba : MonoBehaviour
{

    GameObject closestEnemy;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        closestEnemy = GameObject.Find("execute").GetComponent<execute>().ClosestEnemy;


        transform.position = Vector2.MoveTowards(transform.position, closestEnemy.transform.position, speed*Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "environment")
        {
            GameObject.Find("execute").GetComponent<execute>().isDestroyed = true;
            Destroy(gameObject);
        }

        if(collision.tag == "enemy")
        {
            GameObject.Find("execute").GetComponent<execute>().isDestroyed = true;
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }


    }


}
