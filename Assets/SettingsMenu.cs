using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public bool vsync = true;
    public bool postprocess = true;
    public bool colorcorrect = true;
    public float dialogspeed = 1f;
    // public float resolution;
    public GameObject toggleShader;

    void Start(){
        
    }

    void getShit()
    {

toggleShader = GameObject.Find("ToggleShader");

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
}
