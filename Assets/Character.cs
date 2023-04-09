using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Character : MonoBehaviour
{

    public float dialoguespeed = 1f;

    //increment in conversation in dialogue
    //important for ReadTextEasy Method
    public int increment = 0;

    //Person youre talking to in dialogue
    public string otherchardialogue;

    // World stuff
    public float time = 08.00f;
    public int day = 1;
    public float money = 5.10f;

    public int charclass = 1;

    // Physical
    public int Marksmanship = 0;
    public int Intimidation = 0;
    public int Strength = 0;

    // Handling
    public int Mechanical = 0;
    public int ReactionSpeed = 0;
    public int Coordination = 0;

    // Thoughts
    public int economical = 0;
    public int theoretical = 0;
    public int knowledge = 0;

    // Psych
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

    public void addMoney(float amnt) { money += amnt; }

    public void levelskills(string skilltolevel)
    {

        switch (skilltolevel)
        {
            //phys
            default:
            case "Marksmanship":
                Marksmanship++;
                if (Random.Range(1, 4) == 1 && stability > 0) stability--;
                break;
            case "Intimidation":
                Intimidation++;
                if (Random.Range(1, 4) == 1 && empathy > 0) empathy--;
                break;
            case "Strength":
                Strength++;
                if (Random.Range(1, 4) == 1 && emotional > 0) emotional--;
                break;

            //hand
            case "Mechanical":
                Mechanical++;
                if (Random.Range(1, 4) == 1 && economical > 0) economical--;
                break;
            case "ReactionSpeed":
                ReactionSpeed++;
                if (Random.Range(1, 4) == 1 && theoretical > 0) theoretical--;
                break;
            case "Coordination":
                Coordination++;
                if (Random.Range(1, 4) == 1 && stability > 0) knowledge--;
                break;

            //think
            case "economical":
                economical++;
                if (Random.Range(1, 4) == 1 && Mechanical > 0) Mechanical--;
                break;
            case "theoretical":
                theoretical++;
                if (Random.Range(1, 4) == 1 && ReactionSpeed > 0) ReactionSpeed--;
                break;
            case "knowledge":
                knowledge++;
                if (Random.Range(1, 4) == 1 && Coordination > 0) Coordination--;
                break;

            //psych
            case "stability":
                stability++;
                if (Random.Range(1, 4) == 1 && Marksmanship > 0) Marksmanship--;
                break;
            case "empathy":
                empathy++;
                if (Random.Range(1, 4) == 1 && Intimidation > 0) Intimidation--;
                break;
            case "emotional":
                emotional++;
                if (Random.Range(1, 4) == 1 && Strength > 0) Strength--;
                break;

        }

    }

}
