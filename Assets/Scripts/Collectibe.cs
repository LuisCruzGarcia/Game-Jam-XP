using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibe : MonoBehaviour
{
    public int puntuacion = 100;
    public static SceneLoader Instance;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Instance.SubirPuntuacion(puntuacion);
        }
    }
}
