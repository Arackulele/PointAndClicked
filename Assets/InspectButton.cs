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




        if (gameObject.GetComponent<TextMeshProUGUI>().text == "Inspect"){


            //I was gonna make this so it automatically gets the name and calls the script of that name
            //but unity is so stupid and unwieldy with this that id rather shoot myself than make that work
            //so im just using a switch statement for each item
            //sue me
            switch (itemname)
            {
                default:
                case ("TornNote"):
                    chat.GetComponent<DialogueTornNote>().call();

                    break;


            }

        } else {
            // equipping the thing
        }
    }
}
