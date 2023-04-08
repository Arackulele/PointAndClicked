using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using static Dialogue;


/* 
 
Dialogue Params:

ReadText
Param 1: String, Text you want to add next
Param 2: Bool, Should the player have to click before the next Text Plays
Param 3: Int, which Character should read this Text

ReadTextEasy ( Same as read text but it automatically switches between Characters )
Param 1: String, Text you want to add next
Param 2: Bool, Should the player have to click before the next Text Plays

addQuestion
Param 1:String, Text you want said before Question pops up
Param 2:Int, Amount of answers (from 1-4)
Param 3:String, Answer 1 ( Needs to be added )
Param 4:String, Answer 2 ( Optional, null out if not an answer )
Param 5:String, Answer 3 ( Optional, null out if not an answer )
Param 6:String, Answer 4 ( Optional, null out if not an answer )



In any Text:

Tags are supported
Text waits longer after ,
Text waits even longer after .
Text makes a 1 second pause after %, the character also doesnt get read

 */

public class DialogueTornNote : DialogueManager
{
    // Start is called before the first frame update
    void Start()
    {

        setup();

        dialogueOther.color = new Color(0.0f, 0.30196f, 0.0f);
    }

    public void call()
    {
        Debug.Log("called textstart but in the dialogue torn note you imbecile");

        StartCoroutine(TextStartTornNote());

    }

    public IEnumerator TextStartTornNote()
    {

        yield return new WaitForSeconds(0.5f);

        yield return ReadText("The Note reads:\nDid you get a whoppa", false, 2);

        yield return ReadText("\n\nWhat the hell is that supposed to mean", false, 1);

        yield return ReadText("\n\n\nThe rest of the Note is unintelligable", false, 2);

    }


}
