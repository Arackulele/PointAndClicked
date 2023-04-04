using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using static Character;

public class UiTime : MonoBehaviour
{
    private TextMeshProUGUI Time;
    private GameObject chara;
    private Character charascript;


    void Start()
    {
        Time = gameObject.GetComponent<TextMeshProUGUI>();
        chara = GameObject.Find("Character");
        charascript = chara.GetComponent<Character>();
    }

    // Update is called once per frame
    void Update()
    {
        Time.text = string.Format("{0:N2}", charascript.time);
    }
}
