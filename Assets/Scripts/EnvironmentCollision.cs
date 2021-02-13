using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentCollision : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameObject.GetComponent<Collider2D>().enabled = false;
    }

    IEnumerator colliderEnabler()
    {
        gameObject.GetComponent<Collider2D>().enabled = false;
        yield return new WaitForSeconds(3);
        gameObject.GetComponent<Collider2D>().enabled = true;
    }


}
