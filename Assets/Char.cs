using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Character : MonoBehaviour
{

    public int charclass = 1;

    //Physical
    public int Marksmanship = 0;
    public int Intimidation = 0;
    public int Strength = 0;

    //Handling
    public int Mechanical = 0;
    public int ReactionSpeed = 0;
    public int Coordination = 0;

    //Thoughts
    public int economical = 0;
    public int theoretical = 0;
    public int knowledge = 0;

    //Psych
    public int empathy = 0;
    public int stability = 0;
    public int emotional = 0;


    void Start()
    {



        switch (charclass)
        {
          default:
            case 1:
                Marksmanship = 3;
                Intimidation = 2;
                Strength = 2;
                break;
            case 2:
                Mechanical = 4;
                ReactionSpeed = 2;
                Coordination = 1;
                break;
            case 3:
                economical = 2;
                theoretical = 2;
                knowledge = 3;
                break;
             case 4:
                empathy = 3;
                emotional = 3;
                stability = 1;
                break;
         }


     }

    void levelskills(string skilltolevel)
    {
        switch (skilltolevel)
        {
            //phys
            default:
            case "Marksmanship":
                Marksmanship++;
                if (Random.Range(1, 4) == 1) stability--;
                break;
            case "Intimidation":
                Intimidation++;
                if (Random.Range(1, 4) == 1) empathy--;
                break;
            case "Strength":
                Strength++;
                if (Random.Range(1, 4) == 1) emotional--;
                break;

            //hand
            case "Mechanical":
                Mechanical++;
                if (Random.Range(1, 4) == 1) economical--;
                break;
            case "ReactionSpeed":
                ReactionSpeed++;
                if (Random.Range(1, 4) == 1) theoretical--;
                break;
            case "Coordination":
                Coordination++;
                if (Random.Range(1, 4) == 1) knowledge--;
                break;

            //think
            case "economical":
                economical++;
                if (Random.Range(1, 4) == 1) Mechanical--;
                break;
            case "theoretical":
                theoretical++;
                if (Random.Range(1, 4) == 1) ReactionSpeed--;
                break;
            case "knowledge":
                knowledge++;
                if (Random.Range(1, 4) == 1) Coordination--;
                break;

            //psych
            case "stability":
                stability++;
                if (Random.Range(1, 4) == 1) Marksmanship--;
                break;
            case "empathy":
                empathy++;
                if (Random.Range(1, 4) == 1) Intimidation--;
                break;
            case "emotional":
                emotional++;
                if (Random.Range(1, 4) == 1) Strength--;
                break;

        }


    }


}
