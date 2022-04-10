using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : Interactable{
    [SerializeField] GameObject player;
    [SerializeField] GameObject sword;
    [SerializeField] Dialogue dialogue_box;
    public AudioClip clip;
    public override string GetDescription() {
        return "Press [E] to confront the dragon";
    }

    public override void Interact()
    {
        if (player.GetComponent<Strength>().curr != player.GetComponent<Strength>().max
            || !sword.activeSelf)
            player.GetComponent<Player_Combat>().Die();

        else {
            dialogue_box.SetDialogue("I can finally Die in Peace",clip);
            player.GetComponent<Health>().Reduce(40);
            player.GetComponent<Quests>().kill_dragon = true;
            gameObject.SetActive(false);
        }
    }
}
