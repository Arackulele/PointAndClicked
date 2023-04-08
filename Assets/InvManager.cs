using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Item;
using static ItemIndex;

public class InvManager : MonoBehaviour
{
    public Item[] inventory = new Item[20];
    public Item[] equipinv = new Item[4];
    public GameObject[] slots = new GameObject[20];
    public GameObject[] equipslots = new GameObject[20];

    void Start() {
        Item testItem = new Item();

        for(int i = 0; i < slots.Length; i++){
            slots[i] = GameObject.Find("InvSlot" + i);
            inventory[i] = new Item {name = "none"};
        }

        for (int i = 0; i < equipslots.Length; i++)
        {
            equipslots[i] = GameObject.Find("EquipSlot" + i);
            equipinv[i] = new Item { name = "none" };
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

        for (int i = 0; i < equipslots.Length; i++)
        {
            if (equipinv[i].name != "none")
            {
                equipslots[i].GetComponent<Image>().enabled = true;
                equipslots[i].GetComponent<Image>().sprite = equipinv[i].sprite;
            }
            else
            {
                equipslots[i].GetComponent<Image>().enabled = false;
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

    public void removeItem(int Slot){
        inventory[Slot] = new Item {name = "none"};
    }
}
