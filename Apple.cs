using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : Interactable{
    [SerializeField] private Storage storage;
    [SerializeField] private Dialogue dialogue_box;
    public AudioClip[] clip;
    public override string GetDescription(){
        return "Press [E] to grab";
    }
    public override void Interact(){
        storage.Add(0);
        if(storage.apple == 1){
            dialogue_box.SetDialogue("You see that the rocks can be useful.",clip[0]);
        }
        else{
            dialogue_box.SetDialogue("Apples are always eaten first",clip[1]);
        }
        gameObject.SetActive(false);
    }
}
