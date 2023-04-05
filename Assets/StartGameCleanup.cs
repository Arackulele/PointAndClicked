using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Item;
using static ItemIndex;

public class StartGameCleanup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(HideOnStart());
    }

    public IEnumerator HideOnStart()
    {

        yield return new WaitForSeconds(0.05f);
        GameObject.Find("InvPopUp").SetActive(false);
        GameObject.Find("Scroll View").SetActive(false);
        GameObject.Find("Street2Placeholder").SetActive(false);
        GameObject.Find("Inv").GetComponent<Image>().enabled = true;
        GameObject.Find("Inv").SetActive(false);



    }
}
