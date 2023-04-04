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

public class DialogueTestChar1 : DialogueManager
{
    // Start is called before the first frame update
    void Start()
    {

        setup();

        dialogueOther.color = new Color(0.01176f, 0.09412f, 0.16078f);
    }

    public void call()
    {
        Debug.Log("called textstart");

        StartCoroutine(TextStartChar());

    }

    public IEnumerator TextStartChar()
    {

        yield return new WaitForSeconds(0.5f);

        yield return ReadTextEasy("hi, how are you on this fine day?", false);

        yield return ReadQuestion("\n\nIm doing fine, how are you?", 3, "Im fine.", "Uhh...what?", "'Is he?'", null);

        if (playeranswer == 1)
        {

            yield return ReadText("\nVery nice, i have to go now, though.", false, 2);

            //charascript.money += 0.10f;

        }
        else if (playeranswer == 2)
        {

            yield return ReadText("\nI asked you how you are doing.", false, 2);

        }
        else if (playeranswer == 3)
        {

            yield return ReadText("\n\n\n<color=#0C1833>He is looking scared, he hasnt met you before, has he?</color>", false, 1);
            yield return ReadText("\n\nOh, i havent introduced myself yet, im [i havent come up with a name yet]. Im doing ok, thanks for asking.", false, 1);

            yield return ReadText("\n\n\n\n\n\n\n\n\n\nAh,i havent seen you here before, i'm just a bit weary of people after the robbery that happened the other day.", false, 2);
            charascript.empathy++;
            yield return ReadText("\n\n\n\n\n\n<color=\"white\">+1 Empathy</color>\n<color=#19479E>You noticed his suspicion.</color>", false, 1);
        }

        increment = 0;

        Debug.Log(increment);

    }


}
