using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeToBlack : MonoBehaviour
{
    public GameObject Blackout;
    public GameObject Street1;
    public GameObject Street2;
    public Image blackScreen;
    public float fadeToBlackDuration = 0.2f;

    public string ScreenFadeFrom;

    public string ScreenFadeTo;


    void Start()
    {
        Street1 = GameObject.Find(ScreenFadeFrom);
        Street2 = GameObject.Find(ScreenFadeTo);
        Blackout = GameObject.Find("Fadeout");
        blackScreen = Blackout.GetComponent<Image>();
    }

    public void BlackFade()
    {

        blackScreen.enabled = true;
        blackScreen.color = Color.black;
        blackScreen.canvasRenderer.SetAlpha(0.0f);
        blackScreen.CrossFadeAlpha(1.0f, fadeToBlackDuration, false);
    }
    public void FadeFromBlack()
    {
        blackScreen.color = Color.black;
        blackScreen.enabled = false;
        blackScreen.canvasRenderer.SetAlpha(1.0f);
        blackScreen.CrossFadeAlpha(1.0f, fadeToBlackDuration, false);
    }

    public void callfade() { StartCoroutine(FadeSequence()); }



        public IEnumerator FadeSequence()
    {
        BlackFade();
        yield return new WaitForSeconds(0.4f);
        Street2.SetActive(true);
        FadeFromBlack();
        Street1.SetActive(false);

    }
}
