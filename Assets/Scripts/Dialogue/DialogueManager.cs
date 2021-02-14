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

    public Dialogue[] dialogue;
    int sentencePosition;
    int dialoguePosition;

    SceneLoader scene;

    private void Awake()
    {
        scene = FindObjectOfType<SceneLoader>();
    }

    private void Start()
    {
        DisplayScene();
    }

    private void Update()
    {
        DisplayScene();
    }

    public void DisplayScene()
    {
        background.sprite = dialogue[dialoguePosition].background;
        image.sprite = dialogue[dialoguePosition].artwork;
        dialogueText.text = dialogue[dialoguePosition].sentence[sentencePosition];
        nameText.text = dialogue[dialoguePosition].characterName;
    }

    public void DisplayNextSentence()
    {
        if (sentencePosition < dialogue[dialoguePosition].sentence.Length - 1)
        {
            sentencePosition++;
        } else if (dialoguePosition < dialogue.Length - 1)
        {
            dialoguePosition++;
            sentencePosition = 0;
        }
        else
        {
            scene.LoadNextScene();
        }

    }
}
