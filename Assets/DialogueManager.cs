using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using static Dialogue;


public class DialogueManager : MonoBehaviour
{
    public string[] texts;
    public bool[] question;
    public int[] answeramount;
    public GameObject otherSpeaker;
    public GameObject optionone;

    public TextMeshProUGUI dialogue;
    public TextMeshProUGUI dialogueOther;

    public TextMeshProUGUI option1;

    // Start is called before the first frame update
    void Start()
    {

        setup();

        addText("No text was found for this Character, this is either because of an error or i just havent implemented it yet", false, 0);



        //dialogueOther.color = new Color(0.05490f, 0.04706f, 0.06667f);
    }

    public void setup()
    {

        texts = new string[99];
        question = new bool[99];

        for (int i = 0; i < texts.Length; i++)
        {
            texts[i] = "stop";
            question[i] = false;
        }

        otherSpeaker = GameObject.Find("DialogueTree2");
        optionone = GameObject.Find("DialogueOption1");

        dialogue = gameObject.GetComponent<TextMeshProUGUI>();
        dialogueOther = otherSpeaker.GetComponent<TextMeshProUGUI>();
        option1 = optionone.GetComponent<TextMeshProUGUI>();

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

            if (question[i])
            {


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
        while (!done) // essentially a "while true", but with a bool to break out naturally
        {
            if (Input.GetKeyDown(key))
            {
                done = true; // breaks the loop
            }
            yield return null; // wait until next frame, then continue execution from here (loop continues)
        }

        // now this function returns
    }

    public void addText(string TextToAdd, bool IsQuestion, int answeramount)
    {

        int i = 0;

        while (texts[i] != "stop")
        {
            i++;
            Debug.Log("Skipped");
        }

        texts[i] = TextToAdd;

        if (IsQuestion) question[i] = true;

        Debug.Log("Added " + TextToAdd);
    }
}

