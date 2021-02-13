using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubaWave : MonoBehaviour
{
    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        anim.Play("tubaWave_anim");
        Destroy(gameObject, 3);
    }
}
