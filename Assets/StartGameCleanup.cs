using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Item;
using static ItemIndex;

public class StartGameCleanup : MonoBehaviour
{


    public GameObject Quests;
    public GameObject ScrollView;
    public GameObject InvPopUp;

    void Start()
    {
        Quests.SetActive(true);
        ScrollView.SetActive(true);
        InvPopUp.SetActive(true);
        StartCoroutine(HideOnStart());
    }

    public IEnumerator HideOnStart()
    {
        yield return new WaitForSeconds(0.05f);
        InvPopUp.SetActive(false);
        ScrollView.SetActive(false);
        GameObject.Find("Street2Placeholder").SetActive(false);
        GameObject.Find("Inv").GetComponent<Image>().enabled = true;
        GameObject.Find("Inv").SetActive(false);
        GameObject.Find("Quests").SetActive(false);



    }
}
