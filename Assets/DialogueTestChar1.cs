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

        addText("Balled");

        addQuestion("\nTest Dialogue Char 2", 2, "Test answer", null, null, null);

        addText("\n\nWhys you just say test dialogue char 2");

        addText("\n\n\nno idea mate");

        // addText("\n\n\ntest message for long messages test message for long messages test message for long messages test message for long messages test message for long messages test message for long messages test message for long messages");

        addText("\n\n test message for formatting");

        addText("\n\n\n test message for formatting");

        addText("\n\n\n test message for formatting");

        addText("\n\n\n test message for formatting");

        addText("\n\n\n test message for formatting");

        addText("\n\n\n test message for formatting");

        addText("\n\n\n test message for formatting");

        addText("\n\n\n test message for formatting");

        addText("\n\n\n test message for formatting");

        addText("\n\n\n test message for formatting");

        addText("\n\n\n test message for formatting");

        addText("\n\n\n test message for formatting");

        dialogueOther.color = new Color(0.01176f, 0.09412f, 0.16078f);
    }


}
