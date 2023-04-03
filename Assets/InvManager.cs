using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Item;

public class InvManager : MonoBehaviour
{
    public Item[] inventory = new Item[20];
    public Sprite testSprite;

    void Start() {
        Item testItem = new Item();
        testItem.name = "Hideous Necktie";
        testItem.sprite = testSprite;

        inventory[0] = testItem;

        Debug.Log("Unity is the worst, fuck you!" + inventory[0].name);
    }

    void Update() {
        
    }
}
