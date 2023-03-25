using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public string[] texts;
    public GameObject otherSpeaker;

    public TextMeshProUGUI dialogue;
    public TextMeshProUGUI dialogueOther;

    // Start is called before the first frame update
    void Start()
    {

        texts = new string[99];

        for (int i = 0 ; i < texts.Length; i++)
        {
            texts[i] = "stop";
        }

        otherSpeaker = GameObject.Find("DialogueTree2");
        dialogue = gameObject.GetComponent<TextMeshProUGUI>();
        dialogueOther = otherSpeaker.GetComponent<TextMeshProUGUI>();

        //dialogueOther.color = new Color(0.05490f, 0.04706f, 0.06667f);
    }


public void call()
{

        StartCoroutine(TextStart());

}

    public IEnumerator TextStart()
    {
        int i = 0;

        while (texts[i] != "stop")
        {
            if (i%2!=0)
            {

                yield return PlayText(texts[i], dialogueOther);

            }
                else yield return PlayText(texts[i], dialogue);

        float t = 0.5f;
		foreach (char c in texts[i]) 
		{
            t += 0.125f;
        }
        yield return new WaitForSeconds(t);

                yield return waitForKeyPress(KeyCode.Space);

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
			yield return new WaitForSeconds (0.125f);
		}
	}

    public IEnumerator waitForKeyPress(KeyCode key) // blatantly stolen
    {
        bool done = false;
        while(!done) // essentially a "while true", but with a bool to break out naturally
        {
            if(Input.GetKeyDown(key))
            {
                done = true; // breaks the loop
            }
            yield return null; // wait until next frame, then continue execution from here (loop continues)
        }
    
        // now this function returns
    }

    public void addText(string TextToAdd){

        int i = 0;

        while(texts[i] != "stop"){
            i++;
            Debug.Log("Skipped");
        }

        texts[i] = TextToAdd;
        Debug.Log("Added " + TextToAdd);
    }
}
