using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField]
    public Rigidbody2D rb;
    public float speed;
    public Transform[] path;

    int currentPosition;
    UnityEngine.Vector2 currentPositionHolder;

    public float timerBetweenMovement;
    public bool flag = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        CheckPath();
    }

    void CheckPath()
    {
        if(currentPosition == path.Length)
        {
            currentPosition = 0;
        }
        currentPositionHolder = path[currentPosition].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.position != currentPositionHolder)
        {
            float targetPositionX = path[currentPosition].position.x - rb.position.x;
            float targetPositionY = path[currentPosition].position.y - rb.position.y;

            float angle = Mathf.Atan2(targetPositionX, targetPositionY) * Mathf.Rad2Deg;

            transform.position = UnityEngine.Vector2.MoveTowards(transform.position, path[currentPosition].position, speed * Time.deltaTime);

            UnityEngine.Quaternion rotation = UnityEngine.Quaternion.Euler(new UnityEngine.Vector3(0, 0, -angle));
            transform.rotation = UnityEngine.Quaternion.Slerp(transform.rotation, rotation, 5 * Time.deltaTime);
        } else if(flag)
        {
            StartCoroutine(Wait(timerBetweenMovement));
            flag = false;
        }
    }

    private IEnumerator Wait(float waitTime)
    {
        yield return new WaitForSeconds(waitTime); 
        currentPosition++;
        CheckPath();
        Debug.Log("Coroutine called");
        flag = true;
    }
}