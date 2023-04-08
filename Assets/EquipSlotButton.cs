using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static InvManager;
using TMPro;

public class EquipSlotButton : InvSlotButton
{


    public void onClick(){

        puInspect.GetComponent<InspectButton>().isequipped = true;

        puInspect.GetComponent<TextMeshProUGUI>().text = "Unequip";

        if(Manager.equipinv[slotNum].name!= "none"){
            puTitle.text = Manager.equipinv[slotNum].name;
            puDesc.text = Manager.equipinv[slotNum].description;
            puDiscard.GetComponent<DiscardButton>().slot = slotNum;
            invPopUp.SetActive(true);
            puInspect.GetComponent<InspectButton>().currentSlot = slotNum;
        }
    }
}
