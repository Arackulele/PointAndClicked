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

public class DialogueCitizen : DialogueManager
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

        //p
        yield return ReadTextEasy("Excuse me, do you have a moment to answer a few questions? I'm investigating the murder that happened in this area", false);
        //o
        yield return ReadQuestion("\n\n\n\n\nAye, I heard 'bout the murder. Terrible business, that. What d'you want?", 3, "I'm investigating it.", "You seem suspicious.", "I'm interested.", null);

        if (playeranswer == 1)
        {
            //p
            yield return ReadTextEasy("\n\n\n\nI'm investigating it, you see I think justice should be upheld.", false);
            //o
            yield return ReadQuestion("\n\n\n\nJustice, ya say? Hmm, well, I'll tell ya what I know. I saw a shady character skulkin' around the alley the night of the murder. Might have been worth checkin' out.", 3, "Can you describe the person you saw?", "Did you get a look at their face?", "Thanks for the tip, I'll go check it out.", null);

            if (playeranswer == 1 || playeranswer == 2)
            {

                if (playeranswer == 1)
                {
                    //p
                    yield return ReadTextEasy("\n\n\n\n\n\n\nCan you describe the person you saw?", false);

                }
                else
                {
                    //p
                    yield return ReadTextEasy("\n\n\n\n\n\n\nCan you describe the persons face?", false);
                    //o
                }
                yield return ReadQuestion("\n\n\nHmm, let me think... They were wearin' a dark coat and a hat that covered their face. I couldn't really make out anythin' else.\r\n", 3, "Thanks, that's helpful.", "That's not very specific.", "Did you see anything else?", null);


                if (playeranswer == 1)
                {
                    //p
                    yield return ReadTextEasy("\n\n\n\n\n\nThanks, that's helpful.", false);
                    //o
                    yield return ReadTextEasy("\nI have to go now, bye.", false);

                    yield return ReadText("\n\n\n<color=\"red\">------------</color>", false, 1);

                    chat.closeChat();

                    //end convo here
                }

                if (playeranswer == 2)
                {
                    //p
                    yield return ReadTextEasy("\n\n\n\n\n\nThat's not very specific.", false);
                    //o
                    yield return ReadQuestion("\n\nWell, what can I say? It was dark and I didn't wanna get too close. I'd watch your step if I were you.\r\n", 3, "Thanks anyway.", "Can you think of anything else?", "I'll take my chances.", null);

                    if (playeranswer == 1)
                    {
                        //p
                        yield return ReadTextEasy("\n\n\n\n\n\nThanks, anyway.", false);
                        //o
                        yield return ReadTextEasy("\nI have to go now, bye.", false);


                        yield return ReadText("\n\n\n<color=\"red\">------------</color>", false, 1);

                        chat.closeChat();
                        //end convo here
                    }

                    if (playeranswer == 3)
                    {
                        //p
                        yield return ReadTextEasy("\n\n\n\n\n\nIll take my chances.", false);
                        //o
                        yield return ReadTextEasy("\nI have to go now, bye.", false);
                    }

                    if (playeranswer == 2)
                    {
                        //p
                        yield return ReadTextEasy("\n\nCan you think of anything else?", false);
                        //0
                        yield return ReadTextEasy("\n\nDo I look like a gossiper? If yer want 'sum gossip talk to Tamra downtown, she's sure to have info on eeeeveryone in here.", false);
                        //p
                        yield return ReadTextEasy("\n\nTamra huh?", false);
                        //0
                        yield return ReadTextEasy("\n\nDowntown, left to the fountain and right to Vladde's.", false);

                        //quest unlock Tamara here

                        yield return ReadText("\n\n\n<color=\"red\">------------</color>", false, 1);

                        chat.closeChat();

                    }

                }

                if (playeranswer == 3)
                {
                    //p
                    yield return ReadTextEasy("\n\nNo, sorry. That's all I saw. Good luck with your investigation.", false);


                    yield return ReadText("\n\n\n<color=\"red\">------------</color>", false, 1);

                    chat.closeChat();
                    //end convo here

                }
            }
            if (playeranswer == 3)
            {
                yield return ReadTextEasy("\n\nThanks for the tip, I'll go check it out.", false);

                yield return ReadText("\n\n\n<color=\"red\">------------</color>", false, 1);

                chat.closeChat();
                //end convo here
            }
        }

        if (playeranswer == 2)
        {

            //p
            yield return ReadTextEasy("\n\n\n\nYou seem suspicious. Do you know anything about the murder?", false);
            //o
            yield return ReadQuestion("\n\n\n\nSuspicious? Who're you callin' suspicious? I ain't got nothin' to do with no murder!", 3, "Okay, calm down.", "I'm just asking questions.", "I don't believe you.", null);
            if (playeranswer == 1)
            {
                //p
                yield return ReadTextEasy("\n\n\n\nOkay, calm down. I'm just trying to gather information.", false);

                //o
                yield return ReadQuestion("\n\n\n\nHmph, well, you ain't gonna get much from me. I don't know nothin' about no murder.", 3, "Did you see anything?", "Alright, sorry to have bothered you.", "I'll be going then.", null);

                if (playeranswer == 1)
                {
                    //p
                    yield return ReadTextEasy("\n\n\n\nDid you see anything?", false);
                    //o
                    yield return ReadTextEasy("\n\nNo, now get out of ma sight!", false);

                    yield return ReadText("\n\n\n<color=\"red\">------------</color>", false, 1);

                    chat.closeChat();
                    //end convo

                }
                if (playeranswer == 2)
                {

                    //p
                    yield return ReadTextEasy("\n\n\n\nAlright, sorry to have bothered you.", false);
                    //o
                    yield return ReadTextEasy("\n\nI's fine, but get away now.", false);

                    yield return ReadText("\n\n\n<color=\"red\">------------</color>", false, 1);

                    chat.closeChat();
                    //end convo

                }
                if (playeranswer == 3)
                {

                    //p
                    yield return ReadTextEasy("\n\n\n\nI'll be going then.", false);
                    //o
                    yield return ReadTextEasy("\n\nBye, i ain't got time for this shit.", false);

                    yield return ReadText("\n\n\n<color=\"red\">------------</color>", false, 1);

                    chat.closeChat();
                    //end convo

                }




            }
            if (playeranswer == 2)
            {
                //p
                yield return ReadTextEasy("\n\nI'm just asking questions.", false);
                //o
                yield return ReadQuestion("\n\nWell, maybe you should ask someone else. I ain't got nothin' to say to the likes of you.", 3, "Alright, I'll leave you alone.", "Suit yourself.", "You're not making this easy.", null);

                if (playeranswer == 1)
                {
                    //p
                    yield return ReadTextEasy("\n\n\nAlright, I'll leave you alone.", false);

                    yield return ReadText("\n\n\n<color=\"red\">------------</color>", false, 1);

                    chat.closeChat();
                    //end convo

                }

                if (playeranswer == 2)
                {

                    //p
                    yield return ReadTextEasy("\n\n\nSuit yourself.", false);

                    yield return ReadText("\n\n\n<color=\"red\">------------</color>", false, 1);

                    chat.closeChat();
                    //end convo
                }

                if (playeranswer == 3)
                {
                    //p
                    yield return ReadTextEasy("\n\n\nYou're not making this easy.", false);

                    //p
                    yield return ReadTextEasy("\n\nI ain't here for an interrogation, go back to your friends from Berylit!", false);

                    yield return ReadText("\n\n\n<color=\"red\">------------</color>", false, 1);

                    chat.closeChat();
                    //end convo
                }


            }
            if (playeranswer == 3)
            {
                //p
                yield return ReadTextEasy("\n\n\n\nI don't believe you. You're acting suspicious.", false);
                //o
                yield return ReadTextEasy("\n\n\nLucky yer saying this to men, point yer fingers at anybody else and you might not have any left, if you're catching my drift.", false);

                //go back to start

            }


        }

        if (playeranswer == 3)
        {

            //p
            yield return ReadTextEasy("\n\n\n\nI'm interested in this case. The grapevine told me it was someone from Berylit. Does that ring any bells?", false);
            //o
            yield return ReadTextEasy("\n\n\n\n\nBerylit, eh? Well, I don't know much 'bout that, but tell ya what, those wealthy bastards will have it coming if each and every single on 'uf em gets locked up!", false);
            //p
            yield return ReadTextEasy("\n\n\n\n\n\n\nWhy'd you say that?", false);
            //o
            yield return ReadTextEasy("\n\nSerious question? They know what they're doing by wearing em 'xpensive clothes and jewelry...", false);
            //p
            yield return ReadTextEasy("\n\n\n\n\nWhy's that?", false);
            //o
            yield return ReadTextEasy("\n\nDid you fall from the moon? Before they shat down the Berylit mines, Berylitians were famous for mining gems like crazy, that's where they got all this cash from...", false);
            //p
            yield return ReadTextEasy("\n\n\n\n\n\n\nDo you personally know anyone from Berylit?", false);
            //o
            yield return ReadTextEasy("\n\n\nDo I know anyone from Berylit... Don't make me LAUGH! There's this fancy bloke downtown, name's Kalvin, he thinks he's SOO special for havin' luxury, tell ya what, if you get him locked up, I'll owe ya one hehe.", false);

            yield return ReadText("\n\n\n\n\n\n\n<color=\"red\">------------</color>", false, 1);

            chat.closeChat();
            //end of convo
        }


    }


}
