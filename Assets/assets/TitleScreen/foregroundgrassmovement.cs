using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foregroundgrassmovement : MonoBehaviour
{
    public bool move = true;

    void Start()
    {
                StartCoroutine(parallax());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator parallax()
    {

        while (move == true)
        {

            yield return new WaitForSeconds(0.0005f);
            yield return gameObject.transform.position = new Vector3(gameObject.transform.position.x+0.5f, gameObject.transform.position.y, gameObject.transform.position.z);

            

            if(gameObject.transform.position.x >= 790 ){
                yield return gameObject.transform.position = new Vector3(-700, gameObject.transform.position.y, gameObject.transform.position.z);
                Debug.Log("moved pos");
            }
        }

    }
}
