using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerUp : MonoBehaviour
{
    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject.Find("execute").GetComponent<execute>().speedPowerUp();
        Destroy(gameObject);
    }



}
