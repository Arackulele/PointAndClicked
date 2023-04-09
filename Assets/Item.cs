using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : Object
{
    // Classes: Standart, Hat, Shirt, Trousers, Boots, Firearms
    public string itemClass;
    public Sprite sprite;
    public string description;
    public string name;
    public string intername;
    public List<string> buffs = new List<string>();
    public List<string> debuffs = new List<string>();
    
    void Start() {
        
    }

    void Update() {

    }
}
