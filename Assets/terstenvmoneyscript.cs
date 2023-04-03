using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Item;
using static ItemIndex;
using static InvManager;


public class terstenvmoneyscript : MonoBehaviour
{
    GameObject Index = GameObject.Find("ItemIndexLoader");
    Item Note;
    void Start()
    {
       Note = new Item {name = "Torn Note", description = "A torn up Note, you can still read some of the writing.", sprite = Index.GetComponent<ItemIndex>().TornNoteSprite, itemClass = "default"};
    }

    // Update is called once per frame
    void ClickBehavior()
    {
        InvManager.addItem( Note );
    }
}
