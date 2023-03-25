using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class OpenInv : MonoBehaviour
{



    public void OnPress()
    {

        Image img = GetComponent<Image>();

        Debug.Log("Inv_Opened");

        img.enabled = true;

    }

}