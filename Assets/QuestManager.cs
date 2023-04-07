using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using static Quest;

public class QuestManager : MonoBehaviour
{
    public Quest[] quests = new Quest[6];
    public GameObject[] questSlots = new GameObject[6];

    void Start() {
        for(int i = 0; i < questSlots.Length; i++){
            questSlots[i] = GameObject.Find("Quest" + i);
            quests[i] = new Quest {name = "none"};
            Debug.Log("Name of items in array:" + quests[i].name);
        }
        
    }



        void Update() {
            for(int i = 0; i < questSlots.Length; i++){
                if(quests[i].name != "none"){
                    questSlots[i].GetComponent<TextMeshProUGUI>().enabled = true;
                    questSlots[i].GetComponent<TextMeshProUGUI>().text = quests[i].name;
                } else {
                    questSlots[i].GetComponent<TextMeshProUGUI>().enabled = false;
                }
            }

    }

    public void addQuest(Quest pQuest){
        for(int i = 0; i < questSlots.Length; i++){
            if(quests[i].name == "none"){
                quests[i] = pQuest;
                break;
            }
        }
    }

    public void removeQuest(int Slot){
        quests[Slot] = new Quest {name = "none"};
    }
}
