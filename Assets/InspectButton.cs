using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static InvManager;
using static DialogueManager;
using static DialogueTornNote;
using static ChatScript;
using static Character;
using static Item;
using TMPro;

public class InspectButton : MonoBehaviour
{
    public int currentSlot;
    string itemclass;
    ChatScript chatscript;
    GameObject chat;
    InvManager Manager;
    public bool isequipped = false;
    Character charascript;

    Item toedit;

    void Start(){
        chat = GameObject.Find("DialogueTree");
        Manager = GameObject.Find("Inv").GetComponent<InvManager>();
        chatscript = GameObject.Find("chat").GetComponent<ChatScript>();
        charascript = GameObject.Find("Character").GetComponent<Character>();
    }

    void Update(){
        
    }

    public void onClick()
    {



        if (isequipped == false)
        {
            string itemname = Manager.inventory[currentSlot].intername;




            if (gameObject.GetComponent<TextMeshProUGUI>().text == "Inspect")
            {

                chatscript.openChat();
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

            }
            else
            {

            for(int b = 0; b < Manager.inventory[currentSlot].debuffs.Count; b++){
                    switch (Manager.inventory[currentSlot].debuffs[b])
                    {
                        //phys
                        default:
                        case "Marksmanship":
                            charascript.Marksmanship--;

                            break;
                        case "Intimidation":
                            charascript.Intimidation--;

                            break;
                        case "Strength":
                            charascript.Strength--;

                            break;

                        //hand
                        case "Mechanical":
                            charascript.Mechanical--;

                            break;
                        case "ReactionSpeed":
                            charascript.ReactionSpeed--;

                            break;
                        case "Coordination":
                            charascript.Coordination--;

                            break;

                        //think
                        case "economical":
                            charascript.economical--;

                            break;
                        case "theoretical":
                            charascript.theoretical--;

                            break;
                        case "knowledge":
                            charascript.knowledge--;

                            break;

                        //psych
                        case "stability":
                            charascript.stability--;

                            break;
                        case "empathy":
                            charascript.empathy--;

                            break;
                        case "emotional":
                            charascript.emotional--;

                            break;

                    }
                }

                for(int i = 0; i < Manager.inventory[currentSlot].buffs.Count; i++){
                    switch (Manager.inventory[currentSlot].buffs[i])
                    {
                        //phys
                        default:
                        case "Marksmanship":
                            charascript.Marksmanship++;

                            break;
                        case "Intimidation":
                            charascript.Intimidation++;

                            break;
                        case "Strength":
                            charascript.Strength++;

                            break;

                        //hand
                        case "Mechanical":
                            charascript.Mechanical++;

                            break;
                        case "ReactionSpeed":
                            charascript.ReactionSpeed++;

                            break;
                        case "Coordination":
                            charascript.Coordination++;

                            break;

                        //think
                        case "economical":
                            charascript.economical++;

                            break;
                        case "theoretical":
                            charascript.theoretical++;

                            break;
                        case "knowledge":
                            charascript.knowledge++;

                            break;

                        //psych
                        case "stability":
                            charascript.stability++;

                            break;
                        case "empathy":
                            charascript.empathy++;

                            break;
                        case "emotional":
                            charascript.emotional++;

                            break;

                    }
                }

                string itemclass = Manager.inventory[currentSlot].itemClass;

                toedit = Manager.inventory[currentSlot];
                Manager.inventory[currentSlot] = new Item { name = "none" };


                switch (itemclass)
                {
                    default:
                    case ("equip_hat"):
                        if (Manager.equipinv[0].name == "none") Manager.equipinv[0] = toedit;
                        //else statement that shows a mkessage saying slot is full
                        break;
                    case ("equip_shirt"):
                        if (Manager.equipinv[0].name == "none") Manager.equipinv[1] = toedit;
                        //else statement that shows a mkessage saying slot is full
                        break;
                    case ("equip_pants"):
                        if (Manager.equipinv[0].name == "none") Manager.equipinv[2] = toedit;
                        //else statement that shows a mkessage saying slot is full
                        break;
                    case ("equip_boots"):
                        if (Manager.equipinv[0].name == "none") Manager.equipinv[3] = toedit;
                        //else statement that shows a mkessage saying slot is full
                        break;

                }

                GameObject.Find("InvPopUp").SetActive(false);

            }

        }
        else
        {
            for(int i = 0; i < Manager.equipinv[currentSlot].buffs.Count; i++){
                    switch (Manager.equipinv[currentSlot].buffs[i])
                    {
                        //phys
                        default:
                        case "Marksmanship":
                            charascript.Marksmanship--;

                            break;
                        case "Intimidation":
                            charascript.Intimidation--;

                            break;
                        case "Strength":
                            charascript.Strength--;

                            break;

                        //hand
                        case "Mechanical":
                            charascript.Mechanical--;

                            break;
                        case "ReactionSpeed":
                            charascript.ReactionSpeed--;

                            break;
                        case "Coordination":
                            charascript.Coordination--;

                            break;

                        //think
                        case "economical":
                            charascript.economical--;

                            break;
                        case "theoretical":
                            charascript.theoretical--;

                            break;
                        case "knowledge":
                            charascript.knowledge--;

                            break;

                        //psych
                        case "stability":
                            charascript.stability--;

                            break;
                        case "empathy":
                            charascript.empathy--;

                            break;
                        case "emotional":
                            charascript.emotional--;

                            break;

                    }


                for(int b = 0; b < Manager.equipinv[currentSlot].debuffs.Count; b++){
                    switch (Manager.equipinv[currentSlot].debuffs[b])
                    {
                        //phys
                        default:
                        case "Marksmanship":
                            charascript.Marksmanship++;

                            break;
                        case "Intimidation":
                            charascript.Intimidation++;

                            break;
                        case "Strength":
                            charascript.Strength++;

                            break;

                        //hand
                        case "Mechanical":
                            charascript.Mechanical++;

                            break;
                        case "ReactionSpeed":
                            charascript.ReactionSpeed++;

                            break;
                        case "Coordination":
                            charascript.Coordination++;

                            break;

                        //think
                        case "economical":
                            charascript.economical++;

                            break;
                        case "theoretical":
                            charascript.theoretical++;

                            break;
                        case "knowledge":
                            charascript.knowledge++;

                            break;

                        //psych
                        case "stability":
                            charascript.stability++;

                            break;
                        case "empathy":
                            charascript.empathy++;

                            break;
                        case "emotional":
                            charascript.emotional++;

                            break;

                    }
            }

            toedit = Manager.equipinv[currentSlot];
            Manager.equipinv[currentSlot] = new Item { name = "none" };

            Manager.addItem(toedit);

            GameObject.Find("InvPopUp").SetActive(false);

            


        }

    }

    }

}
