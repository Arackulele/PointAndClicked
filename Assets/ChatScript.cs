using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static InvManager;
using UnityEngine.UI;
using TMPro;

public class ChatScript : MonoBehaviour
{

    GameObject chat;
    GameObject Blackout;
    GameObject chatx;
    GameObject ScrollView;


    void Start() {

        chat = GameObject.Find("chat");
        Blackout = GameObject.Find("Blackout");
        chatx = GameObject.Find("chatx");
        ScrollView = GameObject.Find("Scroll View");

    }



    public void openChat(){

        GameObject.Find("You").GetComponent<TextMeshProUGUI>().enabled = true;
        GameObject.Find("OtherPerson").GetComponent<TextMeshProUGUI>().enabled = true;
        chat.GetComponent<Image>().enabled = true;
        Blackout.GetComponent<Image>().enabled = true;
        chatx.GetComponent<Image>().enabled = true;
        chatx.GetComponent<Button>().enabled = true;
        ScrollView.SetActive(true);

    }

    public void closeChat()
    {

        GameObject.Find("You").GetComponent<TextMeshProUGUI>().enabled = false;
        GameObject.Find("OtherPerson").GetComponent<TextMeshProUGUI>().enabled = false;

        GameObject.Find("DialogueTree").GetComponent<TextMeshProUGUI>().text = "";
        GameObject.Find("DialogueTree2").GetComponent<TextMeshProUGUI>().text = "";

        chat.GetComponent<Image>().enabled = false;
        Blackout.GetComponent<Image>().enabled = false;
        chatx.GetComponent<Image>().enabled = false;
        chatx.GetComponent<Button>().enabled = false;
        ScrollView.SetActive(false);

        GameObject.Find("Character").GetComponent<Character>().increment = 0;

    }
}
