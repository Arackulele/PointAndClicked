using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using static Dialogue;


/* 
 
Dialogue Params:

addText
Param 1: String, Text you want to add next
Param 2: Bool, Should the player have to click before the next Text Plays
Param 3: Int, which Character should read this Text

addQuestion
Param 1:String, Text you want said before Question pops up
Param 2:Int, Amount of answers (from 1-4)
Param 3:String, Answer 1 ( Needs to be added )
Param 4:String, Answer 2 ( Optional, null out if not an answer )
Param 5:String, Answer 3 ( Optional, null out if not an answer )
Param 6:String, Answer 4 ( Optional, null out if not an answer )

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

        yield return ReadTextEasy("Big balled", false);

        yield return ReadQuestion("\nHow do you feel about minorities", 3, "I love them", "I hate them", "Run away", null);

        if (playeranswer == 1)
        {

            yield return ReadText("\nPhew, i thought you hated them, have some money for your great opinions", false, 2);

            charascript.money += 0.10f;

        }
        else if (playeranswer == 2)
        {

            yield return ReadText("\nFuck you, bitchass", false, 2);

        }
        else if (playeranswer == 3)
        {

            yield return ReadText("\nWhered you go", false, 2);

        }

        increment = 0;

        Debug.Log(increment);

    }


}
