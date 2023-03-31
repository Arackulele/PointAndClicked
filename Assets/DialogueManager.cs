using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using static Dialogue;


public class DialogueManager : MonoBehaviour
{
    public string[] texts;
    public bool[] question;
    public int[] answers;
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

    // Start is called before the first frame update
    void Start()
    {

        setup();

        addText("No text was found for this Character, this is either because of an error or i just havent implemented it yet");



        //dialogueOther.color = new Color(0.05490f, 0.04706f, 0.06667f);
    }

    public void setup()
    {

        texts = new string[99];
        question = new bool[99];
        answers = new int[99];

        for (int i = 0; i < texts.Length; i++)
        {
            texts[i] = "stop";
            question[i] = false;
            answers[i] = 0;
        }


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

    public IEnumerator TextStart()
    {

        yield return new WaitForSeconds(0.5f);

        int i = 0;

        Debug.Log(i);

        while (texts[i] != "stop")
        {
            if (i % 2 != 0)
            {

                Debug.Log("playing text");

                yield return PlayText(texts[i], dialogueOther);

            }
            else
            {
                Debug.Log("playing text");
                yield return PlayText(texts[i], dialogue);

            }

            if (question[i] == true)
            {
                Debug.Log("question");

                optionone.SetActive(true);
                option1.text = "test";

                if (answers[i] > 1)
                {
                    optiontwo.SetActive(true);
                    option2.text = "test";
                }

                if (answers[i] > 2)
                {
                    optionthree.SetActive(true);
                    option3.text = "test";
                }

                if (answers[i] > 3)
                {
                    optionfour.SetActive(true);
                    option4.text = "test";
                }

                waitForKeyPress(KeyCode.Mouse0);

            }

            else yield return waitForKeyPress(KeyCode.Mouse0);

            i++;
        }


        // yield return PlayText(text1, dialogue);
        // yield return new WaitForSeconds(2f);
        // yield return waitForKeyPress(KeyCode.Space);
        // yield return PlayText(text2, dialogueOther);

    }

    IEnumerator PlayText(string TextToPlay, TextMeshProUGUI speaker)
    {
        foreach (char c in TextToPlay)
        {
            speaker.text += c;
            yield return new WaitForSeconds(0.075f);
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

    public void addText(string TextToAdd)
    {

        int i = 0;

        while (texts[i] != "stop")
        {
            i++;
            Debug.Log("Skipped");
        }

        texts[i] = TextToAdd;

        Debug.Log("Added " + TextToAdd);
    }

    public void addQuestion(string TextToAdd, int answeramount, string answer1, string answer2, string answer3, string answer4)
    {

        int i = 0;

        while (texts[i] != "stop")
        {
            i++;
            Debug.Log("Skipped");
        }

        texts[i] = TextToAdd;

        question[i] = true;

        if (answeramount != 0) answers[i] = answeramount;

        Debug.Log("Added " + TextToAdd);
    }
}

