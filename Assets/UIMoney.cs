using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using static Character;

public class UIMoney : MonoBehaviour
{
    private TextMeshProUGUI money;
    private GameObject chara;
    private Character charascript;

    void Start()
    {
        money = gameObject.GetComponent<TextMeshProUGUI>();
        chara = GameObject.Find("Character");
        charascript = chara.GetComponent<Character>();
    }

    // Update is called once per frame
    void Update()
    {
        money.text = string.Format("{0:N2}", charascript.money);
    }
}
