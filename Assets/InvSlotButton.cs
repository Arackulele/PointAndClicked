using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static InvManager;
using TMPro;

public class InvSlotButton : MonoBehaviour
{
    InvManager Manager;
    int slotNum;
    GameObject invPopUp;
    TextMeshProUGUI puTitle;
    TextMeshProUGUI puDesc;
    GameObject puInspect;
    GameObject puDiscard;

    void Start() {

        invPopUp = GameObject.Find("InvPopUp");
        puTitle = GameObject.Find("PUTitle").GetComponent<TextMeshProUGUI>();
        puDesc = GameObject.Find("PUDesc").GetComponent<TextMeshProUGUI>();
        puInspect = GameObject.Find("PUInspect");
        puDiscard = GameObject.Find("PUDiscard");
        Manager = GameObject.Find("Inv").GetComponent<InvManager>();
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

    void Update() {
        
    }

    public void onClick(){
        if(Manager.inventory[slotNum].name!= "none"){
            puTitle.text = Manager.inventory[slotNum].name;
            puDesc.text = Manager.inventory[slotNum].description;
            invPopUp.SetActive(true);
        }
    }
}
