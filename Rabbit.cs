using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rabbit : Interactable{

    [SerializeField] private Storage storage;
    [SerializeField] private Dialogue dialogue_box;
    [SerializeField] private Quests q;
    public AudioClip clip;
    public override string GetDescription()
    {
        return "Press [E] to grab";
    }
    public override void Interact()
    {
        q.no_rabbits = false;
        storage.Add(2);
            dialogue_box.SetDialogue("You feel as if Eating this will make you Stronger.",clip);
        gameObject.SetActive(false);
    }
}
