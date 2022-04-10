using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Talk : Interactable{
    [SerializeField] private Dialogue dialogue_box;
    [SerializeField] private string str;
    public AudioClip clip;
    private bool s = false;
    public override string GetDescription(){
        if(!s) return "Press [E] to talk";
        else return "";
    }
    public override void Interact(){
        dialogue_box.SetDialogue(str,clip);
        s = true;
    }
}
