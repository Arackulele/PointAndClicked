using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answer : MonoBehaviour
{
    public bool didthisreturn = false;

    public bool didReturn(){

        if(didthisreturn == true){
            return true;
        } else {
             return false;
        }

    }

    public void setreturntrue() {
        Debug.Log("clicked and set var");
        didthisreturn = true;
    }

}
