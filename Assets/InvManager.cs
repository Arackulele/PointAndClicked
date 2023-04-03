using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Item;

public class InvManager : MonoBehaviour
{
    public Item[] inventory = new Item[20];
    public List<Item> betterInventory;
    public Sprite testSprite;

    void Start() {
        Item testItem = new Item();
        testItem.name = "Hideous Necktie";
        testItem.sprite = testSprite;
        //inventory[0] = new Item();
        betterInventory.Add(testItem);
        Debug.Log("Unity is the worst, fuck you!" + inventory[0].name);
    }

    void Update() {
        
    }
}
