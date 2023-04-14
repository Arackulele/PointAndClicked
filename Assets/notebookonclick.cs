using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Item;
using static ItemIndex;
using static InvManager;


public class notebookonclick : MonoBehaviour
{
    public GameObject Manager;
    public GameObject questManager;
    Quest rebuildSovietOnion;
    Item NoteBook;
    Item ushanka;

    void Start()
    {
        GameObject Index = GameObject.Find("AssetsLoader");
        Manager = GameObject.Find("Inv");

        NoteBook = new Item {name = "Your Notebook",
            description = "As a detective, you gotta keep Notes. Youve been doing this for 15 Years. Youve had 11 Notebooks before this one, theyre lying at home with your Casefiles.",
            sprite = Index.GetComponent<ItemIndex>().NoteBookSprite, itemClass = "default",
            intername = "NoteBook",
            important = true};



    }

    public void ClickBehavior()
    {
        //Manager.GetComponent<InvManager>().addItem(ushanka);
        Manager.GetComponent<InvManager>().addItem(NoteBook);
        //Manager.GetComponent<InvManager>().addItem(Note);

    }
}
