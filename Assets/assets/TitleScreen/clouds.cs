using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clouds : MonoBehaviour
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

        yield return new WaitForSeconds(1f);

        while (move == true)
        {

            yield return new WaitForSeconds(0.0005f);
            yield return gameObject.transform.position = new Vector3(gameObject.transform.position.x+0.012f, gameObject.transform.position.y, gameObject.transform.position.z);

            

            if(gameObject.transform.position.x >= 800 / 1.921819f)
            {
                yield return gameObject.transform.position = new Vector3(0 / 1.921819f, gameObject.transform.position.y, gameObject.transform.position.z);
                Debug.Log("moved pos");
            }
        }

    }
}
