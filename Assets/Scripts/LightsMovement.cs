using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsMovement : MonoBehaviour
{
    public float speed;
    public Transform[] path;

    int currentPosition;
    UnityEngine.Vector2 currentPositionHolder;

    void Start()
    {
        CheckPath();
    }

    void CheckPath()
    {
        if (currentPosition == path.Length)
        {
            currentPosition = 0;
        }
        currentPositionHolder = path[currentPosition].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x != currentPositionHolder.x && transform.position.y != currentPositionHolder.y)
        {
            transform.position = UnityEngine.Vector2.MoveTowards(transform.position, path[currentPosition].position, speed * Time.deltaTime);
        }
        else
        {
            currentPosition++;
            Debug.Log(currentPosition);
            CheckPath();
        }
    }
}
