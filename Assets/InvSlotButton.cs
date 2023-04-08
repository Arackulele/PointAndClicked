using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static InvManager;
using TMPro;

public class InvSlotButton : MonoBehaviour
{
    public InvManager Manager;
    public int slotNum;
    public GameObject invPopUp;
    public TextMeshProUGUI puTitle;
    public TextMeshProUGUI puDesc;
    public GameObject puInspect;
    public GameObject puDiscard;
    public GameObject chat;

    void Start() {
        puTitle = GameObject.Find("PUTitle").GetComponent<TextMeshProUGUI>();
        puDesc = GameObject.Find("PUDesc").GetComponent<TextMeshProUGUI>();
        puInspect = GameObject.Find("PUInspect");
        puDiscard = GameObject.Find("PUDiscard");
        Manager = GameObject.Find("Inv").GetComponent<InvManager>();


        //i dont get invpopup here beacause of a workaround, so i dont have to have the InvPopUp Object enabled in the editor, tahts why its public


        // slotNum = System.Convert.ToInt32(gameObject.name);
        string slot = gameObject.name;
        int value = 0;

        foreach (char c in slot) {
            if ((c >= '0') && (c <= '9')) {
                slotNum = slotNum*10+(c-'0');
        }

}

        Debug.Log(slotNum);
    }




    public void onClick(){

        puInspect.GetComponent<InspectButton>().isequipped = false;

        if (Manager.inventory[slotNum].itemClass.Contains("equip")){
            puInspect.GetComponent<TextMeshProUGUI>().text = "Equip";
        } else {
            puInspect.GetComponent<TextMeshProUGUI>().text = "Inspect";
        }

        if(Manager.inventory[slotNum].name!= "none"){
            puTitle.text = Manager.inventory[slotNum].name;
            puDesc.text = Manager.inventory[slotNum].description;
            puDiscard.GetComponent<DiscardButton>().slot = slotNum;
            invPopUp.SetActive(true);
            puInspect.GetComponent<InspectButton>().currentSlot = slotNum;
        }
    }
}
