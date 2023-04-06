using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using static Dialogue;
using static Character;
using static ChatScript;


public class DialogueManager : MonoBehaviour
{

    public GameObject otherSpeaker;

    public GameObject optionone;
    public GameObject optiontwo;
    public GameObject optionthree;
    public GameObject optionfour;


    public TextMeshProUGUI dialogue;
    public TextMeshProUGUI dialogueOther;

    public TextMeshProUGUI option1;
    public TextMeshProUGUI option2;
    public TextMeshProUGUI option3;
    public TextMeshProUGUI option4;

    public GameObject chara;
    public Character charascript;
    public ChatScript chat;


    Answer answer1;
    Answer answer2;
    Answer answer3;
    Answer answer4;

    public int playeranswer;

    // Start is called before the first frame update
    void Start()
    {

        setup();




        //dialogueOther.color = new Color(0.05490f, 0.04706f, 0.06667f);
    }

    public void setup()
    {

        chara = GameObject.Find("Character");
        charascript = chara.GetComponent<Character>();

        chat = GameObject.Find("chat").GetComponent<ChatScript>();


        otherSpeaker = GameObject.Find("DialogueTree2");
        optionone = GameObject.Find("DialogueOption1");
        optiontwo = GameObject.Find("DialogueOption2");
        optionthree = GameObject.Find("DialogueOption3");
        optionfour = GameObject.Find("DialogueOption4");

        dialogue = gameObject.GetComponent<TextMeshProUGUI>();
        dialogueOther = otherSpeaker.GetComponent<TextMeshProUGUI>();

        option1 = optionone.GetComponent<TextMeshProUGUI>();
        option2 = optiontwo.GetComponent<TextMeshProUGUI>();
        option3 = optionthree.GetComponent<TextMeshProUGUI>();
        option4 = optionfour.GetComponent<TextMeshProUGUI>();
        option4 = optionfour.GetComponent<TextMeshProUGUI>();

    }


    public void call()
    {
        Debug.Log("called textstart");

        StartCoroutine(TextStart());

    }

    public IEnumerator ReadTextEasy(string Text, bool autocontinue)
    {

        if (charascript.increment % 2 != 0)
        {

            Debug.Log("playing text");

            yield return PlayText(Text, dialogueOther);

        }
        else
        {
            Debug.Log("playing text");
            yield return PlayText(Text, dialogue);

        }

        charascript.increment++;

        if (autocontinue == false) yield return waitForKeyPress(KeyCode.Mouse0);

        yield break;

    }

    public IEnumerator ReadText(string Text, bool autocontinue, int chartoread)
    {

        if (chartoread == 2)
        {

            Debug.Log("playing text");

            yield return PlayText(Text, dialogueOther);

        }
        else
        {
            Debug.Log("playing text");
            yield return PlayText(Text, dialogue);

        }

        charascript.increment++;

        if (autocontinue == false) yield return waitForKeyPress(KeyCode.Mouse0);

        yield break;

    }

    public IEnumerator LevelInText(string SkillToLevel, string Flavour)
    {

        charascript.levelskills(SkillToLevel);

        string compoundtext;

        switch (SkillToLevel)
        {
            //phys
            default:
            case "Marksmanship":

                yield return compoundtext = "\n\n<color=\"white\">+1 " + SkillToLevel  + "</color>\n<color=#A02B48>" + Flavour + "</color>";

                break;
            case "Intimidation":

                yield return compoundtext = "\n\n<color=\"white\">+1 " + SkillToLevel + "</color>\n<color=#A02B48>" + Flavour + "</color>";

                break;
            case "Strength":

                yield return compoundtext = "\n\n<color=\"white\">+1 " + SkillToLevel + "</color>\n<color=#A02B48>" + Flavour + "</color>";

                break;

            //hand
            case "Mechanical":

                yield return compoundtext = "\n\n<color=\"white\">+1 " + SkillToLevel + "</color>\n<color=#C47F31>" + Flavour + "</color>";

                break;
            case "ReactionSpeed":

                yield return compoundtext = "\n\n<color=\"white\">+1 " + SkillToLevel + "</color>\n<color=#C47F31>" + Flavour + "</color>";

                break;
            case "Coordination":

                yield return compoundtext = "\n\n<color=\"white\">+1 " + SkillToLevel + "</color>\n<color=#C47F31>" + Flavour + "</color>";

                break;

            //think
            case "economical":

                yield return compoundtext = "\n\n<color=\"white\">+1 " + SkillToLevel + "</color>\n<color=#5BC684>" + Flavour + "</color>";

                break;
            case "theoretical":

                yield return compoundtext = "\n\n<color=\"white\">+1 " + SkillToLevel + "</color>\n<color=#5BC684>" + Flavour + "</color>";

                break;
            case "knowledge":

                yield return compoundtext = "\n\n<color=\"white\">+1 " + SkillToLevel + "</color>\n<color=#5BC684>" + Flavour + "</color>";

                break;

            //psych
            case "stability":

                yield return compoundtext = "\n\n<color=\"white\">+1 " + SkillToLevel + "</color>\n<color=#19479E>" + Flavour + "</color>";

                break;
            case "empathy":

                yield return compoundtext = "\n\n<color=\"white\">+1 " + SkillToLevel + "</color>\n<color=#19479E>" + Flavour + "</color>";

                break;
            case "emotional":

                yield return compoundtext = "\n\n<color=\"white\">+1 " + SkillToLevel + "</color>\n<color=#19479E>" + Flavour + "</color>";

                break;

        }

        yield return ReadText(compoundtext, false, 1);


        charascript.increment--;

        yield break;

    }

    public IEnumerator ReadQuestion(string TextToAdd, int answeramount, string answertext1, string answertext2, string answertext3, string answertext4)
    {

        yield return ReadTextEasy(TextToAdd, true);

        Debug.Log("");

        optionone.SetActive(true);
        option1.text = answertext1;

        answer1 = optionone.GetComponent<Answer>();
        answer2 = optiontwo.GetComponent<Answer>();
        answer3 = optionthree.GetComponent<Answer>();
        answer4 = optionfour.GetComponent<Answer>();

        if (answeramount > 1)
        {
            optiontwo.SetActive(true);
            option2.text = answertext2;


        }

        if (answeramount > 2)
        {
            optionthree.SetActive(true);
            option3.text = answertext3;

        }

        if (answeramount > 3)
        {
            optionfour.SetActive(true);
            option4.text = answertext4;

        }



        while (answer1.didReturn() == false && answer2.didReturn() == false && answer3.didReturn() == false && answer4.didReturn() == false)
        {
            yield return null;
            Debug.Log("In Loop");
        }

        if (answer1.didReturn()) playeranswer = 1;

        if (answer2.didReturn()) playeranswer = 2;

        if (answer3.didReturn()) playeranswer = 3;

        if (answer4.didReturn()) playeranswer = 4;

        Debug.Log("You scumbag");


        answer1.didthisreturn = false;
        answer2.didthisreturn = false;
        answer3.didthisreturn = false;
        answer4.didthisreturn = false;

        option1.text = "";
        option2.text = "";
        option3.text = "";
        option4.text = "";

        yield break;

    }

    public IEnumerator TextStart()
    {

        yield return new WaitForSeconds(0.5f);

        yield return ReadText("Test Text", false, 1);

        yield return  ReadText("\n<color=\"red\">Test Text</color>", false, 2);

        yield return ReadText("\nTest Text", false, 1);

        Debug.Log(charascript.increment);


    }

    IEnumerator PlayText(string TextToPlay, TextMeshProUGUI speaker)
    {

        bool skip = false;
        foreach (char c in TextToPlay)
        {

            if (c != '%') speaker.text += c;



            if (c == '<') { skip = true; }
            else if (c == '>') { skip = false; }

            if (c == '.' || c == '?' || c == '!') yield return new WaitForSeconds(0.3f);
            else if(c == ',') yield return new WaitForSeconds(0.15f);
            else if(c == '%') yield return new WaitForSeconds(1f);
            else if (skip == false ) yield return new WaitForSeconds(0.05f);
        }
    }

    public IEnumerator waitForKeyPress(KeyCode key) // blatantly stolen
    {
        bool done = false;
        while (!done) 
        {
            if (Input.GetKeyDown(key))
            {
                done = true; 
            }
            yield return null; 
        }


    }



}

