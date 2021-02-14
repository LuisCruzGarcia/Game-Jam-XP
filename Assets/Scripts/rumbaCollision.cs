using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rumbaCollision : MonoBehaviour
{
    // Start is called before the first frame update

    public float waitingTime = 5f;
    public float waitingTimeProyectile = 0f;
    float timePassed;
    void Start()
    {
        timePassed = Mathf.Infinity;
    }

    // Update is called once per frame
    void Update()
    {
        timePassed = timePassed + Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "environment")
        {
            GameObject.Find("execute").GetComponent<execute>().instructionLimited = true;
            //Debug.Log("patata");
        }

        if(collision.transform.tag == "enemy")
        {
            GameObject.Find("execute").GetComponent<execute>().instructionLimited = true;

            if(timePassed > waitingTime)
            {
                GetComponent<rumbaHealth>().health--;
                timePassed = 0;
            }
            
        }

        if (collision.transform.tag == "proyectile")
        {
        

            if (timePassed > waitingTimeProyectile)
            {
                GetComponent<rumbaHealth>().health--;
                timePassed = 0;
                Destroy(collision.gameObject);
            }

        }


    }
}
