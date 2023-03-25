using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueTestChar1 : DialogueManager
{
    // Start is called before the first frame update
    void Start()
    {

        texts = new string[99];

        for (int i = 0 ; i < texts.Length; i++)
        {
            texts[i] = "stop";
        }

        addText("Balled");

        addText("\nTest Dialogue Char 2");

        addText("\n\nWhys you just say test dialogue char 2");

        otherSpeaker = GameObject.Find("DialogueTree2");
        dialogue = gameObject.GetComponent<TextMeshProUGUI>();
        dialogueOther = otherSpeaker.GetComponent<TextMeshProUGUI>();

        dialogueOther.color = new Color(0.01176f, 0.09412f, 0.16078f);
    }

}
