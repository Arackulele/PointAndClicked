using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Item;
using static ItemIndex;

public class InvManager : MonoBehaviour
{
    public Item[] inventory = new Item[20];
    public GameObject[] slots = new GameObject[20];

    void Start() {
        Item testItem = new Item();

        for(int i = 0; i < slots.Length; i++){
            slots[i] = GameObject.Find("InvSlot" + i);
            inventory[i] = new Item {name = "none"};
            Debug.Log("Name of items in array:" + inventory[i].name);
        }
        
    }



        void Update() {
        for(int i = 0; i < slots.Length; i++){
            if(inventory[i].name != "none"){
                slots[i].GetComponent<Image>().enabled = true;
                slots[i].GetComponent<Image>().sprite = inventory[i].sprite;
            } else {
                slots[i].GetComponent<Image>().enabled = false;
            }
        }

    }

    public void addItem(Item pItem){
        for(int i = 0; i < slots.Length; i++){
            if(inventory[i].name == "none"){
                inventory[i] = pItem;
                break;
            }
        }
    }
}
