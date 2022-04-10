using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shopkeeper : Interactable{

    [SerializeField] private Dialogue dialogue_box;
    [SerializeField] private string str1;
    [SerializeField] private string str2;
    [SerializeField] private Storage storage;
    [SerializeField] private GameObject guard;
    public AudioClip clip0;
    public AudioClip clip1;
    
    
    public override string GetDescription(){
        return "Press [E] to Sell all items";
    }
    public override void Interact(){

        storage.coins += storage.fish * 10;
        storage.fish = 0;
        storage.coins += storage.rabbits * 20;
        storage.rabbits = 0;
        storage.coins += storage.apple * 5;
        storage.apple = 0;

        guard.SetActive(true);

        if (storage.coins > 100) dialogue_box.SetDialogue(str2,clip0);
        else dialogue_box.SetDialogue(str1,clip1);
       
    }
}
