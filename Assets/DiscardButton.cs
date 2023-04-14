using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static InvManager;
using TMPro;

public class DiscardButton : MonoBehaviour
{
    private InvManager manager;
    public int slot = 0;

    void Start(){
        manager = GameObject.Find("Inv").GetComponent<InvManager>();

    }

    void Update(){
        
    }

    public void onClick(){

        if (manager.inventory[slot].important);
        else manager.removeItem(slot);

        GameObject.Find("InvPopUp").SetActive(false);
    }
}
