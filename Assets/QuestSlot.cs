using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static InvManager;
using TMPro;

public class QuestSlot : MonoBehaviour
{
    QuestManager Manager;
    int slotNum;
    TextMeshProUGUI puTitle;
    TextMeshProUGUI puDesc;
    TextMeshProUGUI puAddInfo;
    TextMeshProUGUI puObjective;

    void Start() {
        puTitle = GameObject.Find("Name").GetComponent<TextMeshProUGUI>();
        puDesc = GameObject.Find("desc").GetComponent<TextMeshProUGUI>();
        puAddInfo = GameObject.Find("info").GetComponent<TextMeshProUGUI>();
        puObjective = GameObject.Find("Objective").GetComponent<TextMeshProUGUI>();
        Manager = GameObject.Find("Quests").GetComponent<QuestManager>();

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
        if(Manager.quests[slotNum].name!= "none"){
            puTitle.text = Manager.quests[slotNum].name;
            puDesc.text = Manager.quests[slotNum].description;
            puAddInfo.text = Manager.quests[slotNum].additional_info;
            puObjective.text = Manager.quests[slotNum].task;
        }
    }
}
