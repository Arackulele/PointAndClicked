using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using static Dialogue;


public class DialogueTestChar1 : DialogueManager
{
    // Start is called before the first frame update
    void Start()
    {

        setup();

        addText("Balled", false, 0);

        addText("\nTest Dialogue Char 2", false, 0);

        addText("\n\nWhys you just say test dialogue char 2", false, 0);

        addText("\n\n\nno idea mate", false, 0);


        dialogueOther.color = new Color(0.01176f, 0.09412f, 0.16078f);
    }


}
