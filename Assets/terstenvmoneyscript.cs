using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Item;
using static ItemIndex;
using static InvManager;


public class terstenvmoneyscript : MonoBehaviour
{
    public GameObject Manager;
    public GameObject questManager;
    Quest rebuildSovietOnion;
    Item Note;

    void Start()
    {
        GameObject Index = GameObject.Find("ItemIndexLoader");
        questManager = GameObject.Find("Quests");
        rebuildSovietOnion = new Quest {name = "Rebuild the Soviet Onion", description = "You need find Comrade Trotsky and help him farm some Onion to reestablish the great communist Soviet Onion Farm", additional_info = "-haha funny Soviet Onion do it now you capitalist pig", task = "Current Objective: \nfind Comrade Trotsky to start rebuilding the farm"};
        Manager = GameObject.Find("Inv");
        Note = new Item {name = "Torn Note", description = "A torn up Note, you can still read some of the writing.", sprite = Index.GetComponent<ItemIndex>().TornNoteSprite, itemClass = "default"};
    }

    // Update is called once per frame
    public void ClickBehavior()
    {
        Manager.GetComponent<InvManager>().addItem( Note );
        questManager.GetComponent<QuestManager>().addQuest(rebuildSovietOnion);
    }
}
