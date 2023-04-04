using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using static Character;

public class UiDate : MonoBehaviour
{
    private TextMeshProUGUI Date;
    private GameObject chara;
    private Character charascript;

    void Start()
    {
        Date = gameObject.GetComponent<TextMeshProUGUI>();
        chara = GameObject.Find("Character");
        charascript = chara.GetComponent<Character>();
    }

    // Update is called once per frame
    void Update()
    {
        Date.text = "Day " + charascript.day;
    }
}
