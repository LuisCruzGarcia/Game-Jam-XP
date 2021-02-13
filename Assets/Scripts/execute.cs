using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class execute : MonoBehaviour
{
    // 1-UP, 2-Down, 3-Rigth, 4-Left
    public int[] instructions;
    Button play;
    GameObject rumba;
    public float distance = 5f;
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        play = GetComponent<Button>();
        play.onClick.AddListener(executeInstructions);
        rumba = GameObject.Find("rumba");
    }

    // Update is called once per frame
   
    void executeInstructions()
    {
        Up();
    }


    void Up()
    {

        transform.position += transform.up * Time.deltaTime * speed;
       //rumba.transform.Translate(Vector3.up * distance * Time.deltaTime);
        
    }

}
