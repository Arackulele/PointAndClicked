using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using static Character;

public class otherpersonupdate : MonoBehaviour
{
    private GameObject chara;
    private Character charascript;

    void Start()
    {
        chara = GameObject.Find("Character");
        charascript = chara.GetComponent<Character>();
    }

    // Update is called once per frame
    void Update()
    {

        gameObject.GetComponent<TextMeshProUGUI>().text = charascript.otherchardialogue;

    }
}
