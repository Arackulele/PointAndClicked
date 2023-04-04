using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using static Character;

public class SetSkills : MonoBehaviour
{
    private TextMeshProUGUI Time;
    private GameObject chara;
    private Character charascript;

    TextMeshProUGUI Mark;
    TextMeshProUGUI Intim;
    TextMeshProUGUI Strngth;

    TextMeshProUGUI Mech;
    TextMeshProUGUI Speed;
    TextMeshProUGUI Coord;

    TextMeshProUGUI Econ;
    TextMeshProUGUI Theo;
    TextMeshProUGUI Knowl;

    TextMeshProUGUI Emp;
    TextMeshProUGUI Stabl;
    TextMeshProUGUI Emo;

    void Start()
    {

        Mark = GameObject.Find("Mark").GetComponent<TextMeshProUGUI>();
        Intim = GameObject.Find("Intim").GetComponent<TextMeshProUGUI>();
        Strngth = GameObject.Find("Strngth").GetComponent<TextMeshProUGUI>();

        Mech = GameObject.Find("Mech").GetComponent<TextMeshProUGUI>();
        Speed = GameObject.Find("Speed").GetComponent<TextMeshProUGUI>();
        Coord = GameObject.Find("Coord").GetComponent<TextMeshProUGUI>();

        Mech = GameObject.Find("Mech").GetComponent<TextMeshProUGUI>();
        Speed = GameObject.Find("Speed").GetComponent<TextMeshProUGUI>();
        Coord = GameObject.Find("Coord").GetComponent<TextMeshProUGUI>();

        Econ = GameObject.Find("Econ").GetComponent<TextMeshProUGUI>();
        Theo = GameObject.Find("Theo").GetComponent<TextMeshProUGUI>();
        Knowl = GameObject.Find("Knowl").GetComponent<TextMeshProUGUI>();

        Emp = GameObject.Find("Emp").GetComponent<TextMeshProUGUI>();
        Stabl = GameObject.Find("Stabl").GetComponent<TextMeshProUGUI>();
        Emo = GameObject.Find("Emo").GetComponent<TextMeshProUGUI>();

        chara = GameObject.Find("Character");
        charascript = chara.GetComponent<Character>();
    }

    // Update is called once per frame
    void Update()
    {

        Mark.text = "Marksmanship\n    " + charascript.Marksmanship;
        Intim.text = "Marksmanship\n    " + charascript.Intimidation;
        Strngth.text = "Marksmanship\n    " + charascript.Strength;

        Mech.text = "Mehanical\n    " + charascript.Mechanical;
        Speed.text = "Reac. Speed\n    " + charascript.ReactionSpeed;
        Coord.text = "Coorination\n    " + charascript.Coordination;

        Econ.text = "Economical\n    " + charascript.economical;
        Theo.text = "Theoretical\n    " + charascript.theoretical;
        Knowl.text = "Knowledge\n    " + charascript.knowledge;

        Emp.text = "Empathy\n    " + charascript.empathy;
        Stabl.text = "Stability\n    " + charascript.stability;
        Emo.text = "Emotional\n    " + charascript.emotional;

    }
}
