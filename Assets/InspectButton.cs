using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static InvManager;
using TMPro;

public class InspectButton : MonoBehaviour
{

    GameObject chat;

    void Start(){
        chat = GameObject.Find("Chat");

    }

    void Update(){
        
    }

    public void onClick(){

        chat.SetActive(true);

    }
}
