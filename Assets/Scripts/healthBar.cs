using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthBar : MonoBehaviour
{
    rumbaHealth player;
    Slider slider;
    Text text;
    int percentage;
    float percentageFloat;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("rumba").GetComponent<rumbaHealth>();
        slider = GetComponent<Slider>();
        text = GameObject.Find("healthT").GetComponent<Text>();
        slider.maxValue = player.health;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = player.health;
        percentageFloat = (player.health * 100) / slider.maxValue;
        percentage = (int)percentageFloat;

        text.text = percentage.ToString() + "%";


    }
}
