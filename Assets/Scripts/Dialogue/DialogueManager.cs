using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;
    public Image image;
    public Image background;

    public AudioSource audio;

    public Dialogue[] dialogue;
    int sentencePosition;
    int dialoguePosition;

    public Animator anim;
    public bool flag = true;

    SceneLoader scene;

    private void Awake()
    {
        scene = FindObjectOfType<SceneLoader>();
    }

    private void Start()
    {
        DisplayScene();
        anim.Play("image_easyin");
        audio.Play(0);
    }

    private void Update()
    {
        DisplayScene();
    }


    public void DisplayScene()
    {
        background.sprite = dialogue[dialoguePosition].background;
        image.sprite = dialogue[dialoguePosition].artwork;
        nameText.text = dialogue[dialoguePosition].characterName;
        nameText.color = dialogue[dialoguePosition].color;
        StartCoroutine(TypeSentence(dialogue[dialoguePosition].sentence[sentencePosition]));
    }

    private IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach(char letter in dialogue[dialoguePosition].sentence[sentencePosition].ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }

    public void DisplayNextSentence()
    {
        if (sentencePosition < dialogue[dialoguePosition].sentence.Length - 1)
        {
            audio.Play(0);
            sentencePosition++;
        } else if (dialoguePosition < dialogue.Length - 1)
        {
            audio.Play(0);
            StartCoroutine(Wait(1f));
        }
        else
        {
            scene.LoadNextScene();
        }   
    }

    private IEnumerator Wait(float waitTime)
    {
        anim.Play("image_easyout");
        yield return new WaitForSeconds(waitTime);
        dialoguePosition++;
        sentencePosition = 0;
        anim.Play("image_easyin");
    }
}
