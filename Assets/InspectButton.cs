using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static InvManager;
using static DialogueManager;
using static DialogueTornNote;
using TMPro;

public class InspectButton : MonoBehaviour
{
    public int currentSlot;
    GameObject chat;

    void Start(){
        chat = GameObject.Find("DialogueTree");

    }

    void Update(){
        
    }

    public void onClick(){

        string itemname = GameObject.Find("Inv").GetComponent<InvManager>().inventory[currentSlot].intername;
        Debug.Log("Dialogue" + itemname);

        if(gameObject.GetComponent<TextMeshProUGUI>().text == "Inspect"){
            DialogueManager callDialogue = chat.GetComponent("Dialogue" + itemname) as DialogueManager;
            callDialogue.call();
        } else {
            // equipping the thing
        }

    }
}
