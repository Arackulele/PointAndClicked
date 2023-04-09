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

LevelInText
Param 1:String, the Skill you want to Level, options:
Marksmanship, Intimidation, Strength
Mechanical, ReactionSpeed, Coordination
economical, theoretical, knowledge
stability, empathy, emotional
Param 2:Flavor Text, what you di to get this skill point ( ex. You noticed x)

THIS TEXT IS ALWAYS READ BY THE PLAYER AND DOES NOT INCREMENT THE DIALOGUE

In any Text:

Tags are supported
Text waits longer after ,
Text waits even longer after .
Text makes a 1 second pause after %, the character also doesnt get read

 */

public class DialogueTamra : DialogueManager
{
    // Start is called before the first frame update
    void Start()
    {

        setup();

        dialogueOther.color = new Color(0.18039f, 0.10196f, 0.19216f);
    }

    public void call()
    {
        Debug.Log("called textstart");

        StartCoroutine(TextStartChar());

    }

    public IEnumerator TextStartChar()
    {
        charascript.otherchardialogue = "Tamra Merina";
        charascript.increment++;

        yield return new WaitForSeconds(0.5f);

        //o
        yield return ReadTextEasy("Oh yeah, and then did you know that he-... Hold on Sil, this person decided to annoy me today, how wonderful.", false);

        //p
        yield return ReadTextEasy("\n\n\n\n...are you Tamra?", false);

        //o
        yield return ReadTextEasy("\n\nYeah.", false);

        //p
        yield return ReadTextEasy("\n\nI heard you're knowledgeable on the people here, I'm investigating a murder that has happened, do you know anything about it?", false);

        //o
        yield return ReadTextEasy("\n\n\n\n\n\nOh honey, do I know anything about the murder? I've been talking to everyone in this town about it. What do you want to know?", false);

        charascript.increment++;

        //o (friend)
        charascript.otherchardialogue = "Silvia Bronislawa";
        yield return ReadQuestion("\n\n<color=#de8c1d>Yeah, share the gossip, Tam!</color>", 2, "Alleyway at midnight?", "Grudge against the victim?", null, null);


        if (playeranswer == 1)
        {

            //p
            yield return ReadTextEasy("\n\n\n\n\n\n\n\nHave you heard anything about someone suspicious lurking in the alleyway at midnight?", false);

            //o
            charascript.otherchardialogue = "Tamra Merina";
            yield return ReadTextEasy("\n\n\n\n\nOh yes, honey. I heard that someone saw a shady figure lurking around there. I don't want to spread rumors or anything, but I heard they were wearing a dark coat and a hat.", false);

            charascript.increment++;

            //o (friend)
            charascript.otherchardialogue = "Silvia Bronislawa";
            yield return ReadTextEasy("\n\n<color=#de8c1d>Ooooh, do you think it could be the killer?</color>", false);

            charascript.increment++;

            //o
            charascript.otherchardialogue = "Tamra Merina";
            yield return ReadQuestion("\n\n\nMaybe.", 2, "Know anything else?", "Too simple...", null, null);

            if (playeranswer == 1)
            {

                //p
                yield return ReadTextEasy("\n\n\n\n\n\n\n\n\n\n\n\n\n\nThank you for the information, do you know anything else?", false);

                //o
                yield return ReadTextEasy("\n\n\n\nAnytime, honey. You know I love to be in the know.", false);

                charascript.increment++;

                //o (friend)
                charascript.otherchardialogue = "Silvia Bronislawa";
                yield return ReadTextEasy("\n\n<color=#de8c1d>Yeah, she loves to feel important.</color>", false);

                charascript.increment++;

                //o
                charascript.otherchardialogue = "Tamra Merina";
                yield return ReadTextEasy("\n\nI heard that!", false);

                //p
                yield return ReadTextEasy("\n\n\n\n\n\n\n\n...Do you?", false);

                //o
                yield return ReadQuestion("\n\nHmm, let me think. Oh, I did hear that the victim had a bit of a falling out with their business partner recently.", 2, "How do you know?", "I need concrete evidence.", null, null);


                if (playeranswer == 1)
                {

                    //p
                    yield return ReadTextEasy("\n\n\n\n\nHow do you know that?", false);

                    //o
                    yield return ReadTextEasy("\n\nI wasn't born yesterday you know, I have connections.", false);

                    //p
                    yield return ReadTextEasy("\n\n\nRight.", false);

                    //o
                    yield return ReadTextEasy("\n\nNow, do you have any more questions, I'm a busy woman and I haven't got all day.", false);


                }

                //p
                yield return ReadTextEasy("\n\n\n\n\nI don't trust rumors, I need concrete evidence.", false);

                //o
                yield return ReadTextEasy("\n\n\n\nYou're the one who came crawling, not me. Rumors around here are some peoples' only way to keep in touch. Wish I did, though. It's always more fun when there's more information to share.", false);

                //p
                yield return ReadTextEasy("\n\n\n\n\n\n\n\n\nI don't think that's very helpful.", false);

                //o
                yield return ReadTextEasy("\n\n\nWell, excuse me! I'm just trying to be a good person and help out.", false);


                charascript.increment++;

                //o (friend)
                charascript.otherchardialogue = "Silvia Bronislawa";
                yield return ReadTextEasy("\n\n<color=#de8c1d>Yeah, Tamra's just trying to be helpful.</color>", false);

                charascript.increment++;


                //o
                charascript.otherchardialogue = "Tamra Merina";
                yield return ReadTextEasy("\n\nThat's right! And you should be grateful for any information you get.", false);

                yield return HiddenDialogueEnd();

                yield return ReadText("\n\n\n\n\n\n\n\n\n\n\n\n<color=\"red\">------------</color>", false, 1);

                chat.closeChat();

            }

        }

            if (playeranswer == 2)
            {

                //p
                yield return ReadTextEasy("\n\n\n\n\n\n\n\nDo you know anyone who had a grudge against the victim?", false);

                //o
                yield return ReadTextEasy("\n\n\nHmm, let me think. Oh, I did hear that their neighbor had a bit of a feud.", false);

                //p
                yield return ReadTextEasy("\n\n\n\nA feud? What kind of feud?", false);

                //o
                yield return ReadTextEasy("\n\nOh, just a silly argument over a noisy dog, I think. But who knows what could have escalated from there.", false);

                charascript.increment++;

                //o (friend)
                charascript.otherchardialogue = "Silvia Bronislawa";
                yield return ReadTextEasy("\n\n<color=#de8c1d>Oh yeah, I heard about that too. Apparently, it got pretty heated.</color>", false);

                charascript.increment++;

                //o
                charascript.otherchardialogue = "Tamra Merina";
                yield return ReadQuestion("\n\nAnd you know what they say about people who can't control their tempers. It wouldn't surprise me if one of them snapped and did something regrettable.", 3, "Do you know the neighbor's name?", "Escalated to murder?", "Where can I find them?", null);

                if (playeranswer == 1)
                {
                    //o
                    yield return ReadTextEasy("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\nDo you know the neighbor's name?", false);

                    //o
                    yield return ReadTextEasy("\n\n\nGriv Jalslaw.", false);

                yield return HiddenDialogueEnd();

                yield return ReadText("\n\n\n\n\n\n\n\n\n\n\n\n<color=\"red\">------------</color>", false, 1);

                    chat.closeChat();
                }

                    if ( playeranswer == 2) 
                {
                    //p
                    yield return ReadTextEasy("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\nDo you really think such an unserious conversation could've escalated to murder?", false);

                    //o
                    yield return ReadTextEasy("\n\n\n\n\nThe neighbor's known for having a short temper.", false);

                    charascript.increment++;

                    //o (friend)
                    charascript.otherchardialogue = "Silvia Bronislawa";
                    yield return ReadTextEasy("\n\n<color=#de8c1d>Poor victim, they didn't deserve living near him.</color>", false);

                    charascript.increment++;

                    //o
                    charascript.otherchardialogue = "Tamra Merina";
                    yield return ReadTextEasy("\n\nThat's true, I wouldn't wish for my worst enemy to live near him.", false);

                yield return HiddenDialogueEnd();

                yield return ReadText("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n<color=\"red\">------------</color>", false, 1);

                    chat.closeChat();

                }

                    if ( playeranswer == 3)
                {
                    //p
                    yield return ReadTextEasy("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\nDo you know where I could find these neighbors?", false);

                    //o
                    yield return ReadTextEasy("\n\n\nHmm, let me think. I believe they live in one of the houses down on Stasla Street. I can't remember the exact address, but it shouldn't be too hard to find.", false);

                    charascript.increment++;

                    //o (friend)
                    charascript.otherchardialogue = "Silvia Bronislawa";
                    yield return ReadTextEasy("\n\n<color=#de8c1d>Yeah, just look for the house with the overgrown lawn and the barking dog. You can't miss it.</color>", false);


                yield return HiddenDialogueEnd();

                yield return ReadText("\n\n\n\n\n\n\n\n\n\n\n\n<color=\"red\">------------</color>", false, 1);

                    chat.closeChat();
                }

            }


    }

    public IEnumerator HiddenDialogueEnd()
    {

        if (charascript.increment % 2 != 0) charascript.increment++;

        //p
        yield return ReadTextEasy("\n\n\n\n\n\n\n\n\n\n\n\nThank you, both for your help. I'll go check out the leads.", false);

        //o
        charascript.otherchardialogue = "Tamra Merina";
        yield return ReadTextEasy("\n\n\n\nAnytime, dear. And if you happen to find anything juicy, you know where to find me.", false);

        charascript.increment++;

        //o (friend)
        charascript.otherchardialogue = "Silvia Bronislawa";
        yield return ReadTextEasy("\n\n<color=#de8c1d>Just be careful not to get too caught up in the drama, okay? It's not worth sacrificing your own peace of mind.</color>", false);

        charascript.increment++;

        //o
        charascript.otherchardialogue = "Tamra Merina";
        yield return ReadTextEasy("\n\n\nOh, don't worry about him. He knows how to handle himself. Right, dear?", false);

        //p
        yield return ReadTextEasy("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\nYou know im a detective , right? This is my job.", false);

        //o
        yield return ReadTextEasy("\n\n\n\nOh, that explains the Questions.", false);



        yield break;
    
    
    }


}
