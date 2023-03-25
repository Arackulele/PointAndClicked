using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    private string text1;
    private string text2;
    private GameObject otherSpeaker;

    TextMeshProUGUI dialogue;
    TextMeshProUGUI dialogueOther;

    // Start is called before the first frame update
    void Start()
    {
        otherSpeaker = GameObject.Find("DialogueTree2");
        dialogue = gameObject.GetComponent<TextMeshProUGUI>();
        dialogueOther = otherSpeaker.GetComponent<TextMeshProUGUI>();
        text1 = "fuck you";
        text2 = "\n\nsrcrew yau";
    }


public void call()
{

        StartCoroutine(TextStart());

}

    public IEnumerator TextStart()
    {

        yield return PlayText(text1, dialogue);

        // yield return new WaitForSeconds(2f);

        yield return waitForKeyPress(KeyCode.Space);

        yield return PlayText(text2, dialogueOther);
        
    }

    IEnumerator PlayText(string TextToPlay, TextMeshProUGUI speaker)
	{
		foreach (char c in TextToPlay) 
		{
			speaker.text += c;
			yield return new WaitForSeconds (0.125f);
		}
	}

    private IEnumerator waitForKeyPress(KeyCode key) // blatantly stolen
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
}
