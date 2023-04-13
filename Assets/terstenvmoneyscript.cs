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
    Item ushanka;

    void Start()
    {
        GameObject Index = GameObject.Find("AssetsLoader");
        questManager = GameObject.Find("Quests");
        rebuildSovietOnion = new Quest {name = "Rebuild the Soviet Onion", description = "You need find Comrade Trotsky and help him farm some Onion to reestablish the great communist Soviet Onion Farm", additional_info = "-haha funny Soviet Onion do it now you capitalist pig", task = "Current Objective: \nfind Comrade Trotsky to start rebuilding the farm"};
        Manager = GameObject.Find("Inv");
        Note = new Item {name = "Torn Note", description = "A torn up Note, you can still read some of the writing.", sprite = Index.GetComponent<ItemIndex>().TornNoteSprite, itemClass = "default", intername = "TornNote"};

        ushanka = new Item {name = "Ushanka",
         description = "A very communist fur hat\n </color>\n<color=#5BC684> -1 Economical</color> No longer capitalist scum\n </color>\n<color=#5BC684> +1 Theoretical</color> Karl Moneybags Mark",
         sprite = Index.GetComponent<ItemIndex>().TornNoteSprite,
         itemClass = "equip_hat",
         intername = "ushanka"};

        ushanka.buffs.Add("theoretical");
        ushanka.debuffs.Add("economical");

    }

    // Update is called once per frame
    public void ClickBehavior()
    {
        //Manager.GetComponent<InvManager>().addItem(ushanka);
        Manager.GetComponent<InvManager>().addItem(Note);
        questManager.GetComponent<QuestManager>().addQuest(rebuildSovietOnion);
        Manager.GetComponent<InvManager>().addItem(ushanka);
        //Manager.GetComponent<InvManager>().addItem(Note);

    }
}
