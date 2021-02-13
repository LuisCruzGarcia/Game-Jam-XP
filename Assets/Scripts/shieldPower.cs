using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shieldPower : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject.Find("execute").GetComponent<execute>().shield();
        GameObject.Find("execute").GetComponent<execute>().shieldOn = true;
        Destroy(gameObject);

    }
}
