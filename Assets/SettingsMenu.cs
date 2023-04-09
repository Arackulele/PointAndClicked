using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Character;
using UnityEditor;

public class SettingsMenu : MonoBehaviour
{
    // public float resolution;
    Character chara;
    public GameObject toggleShader;
    public GameObject toggleColor;
    public GameObject SlideSpeed;

    void Start(){
        chara = GameObject.Find("Character").GetComponent<Character>();
    }

    void getShit()
    {
    toggleShader = GameObject.Find("ToggleShader");
    toggleColor = GameObject.Find("ToggleColorPP");
    SlideSpeed = GameObject.Find("DialogueSpeed");

    }

    public void onClickShader(){

        getShit();

        if(toggleShader.GetComponent<Toggle>().isOn == true){
            GameObject.Find("Main Camera").GetComponent<CRTPostEffecter>().enabled = true;
        }
        if(toggleShader.GetComponent<Toggle>().isOn == false){
            GameObject.Find("Main Camera").GetComponent<CRTPostEffecter>().enabled = false;
        }
    }

    public void onClickColor()
    {

        getShit();

        if (toggleColor.GetComponent<Toggle>().isOn == true)
        {
            GameObject.Find("Main Camera").GetComponent<GammaCorrector>().enabled = true;
            GameObject.Find("Main Camera").GetComponent<ColorCorrection>().enabled = true;
        }
        if (toggleColor.GetComponent<Toggle>().isOn == false)
        {
            GameObject.Find("Main Camera").GetComponent<GammaCorrector>().enabled = false;
            GameObject.Find("Main Camera").GetComponent<ColorCorrection>().enabled = false;
        }
    }

    public void onChangeDialogueSpeed()
    {

        getShit();

        chara.dialoguespeed = (SlideSpeed.GetComponent<Scrollbar>().value*2) + 0.5f;


    }





}
