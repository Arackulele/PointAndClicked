using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Item;

public class ItemIndex : MonoBehaviour
{

    public Item TornNote;
    public Sprite TornNoteSprite;


    void Start()
    {

        TornNote = new Item {name = "Torn Note", description = "A torn up Note, you can still read some of the writing.", sprite = TornNoteSprite, itemClass = "default"};

        
    }

    public Item GetItem(string InternalName)
    {

        if (InternalName == "TornNote") return TornNote;
        else return null;
    }

}