using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bear : Interactable
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject sword;
    [SerializeField] Dialogue dialogue_box;
    public AudioClip clip;
    public override string GetDescription()
    {
        return "Press [E] to confront the bear";
    }

    public override void Interact()
    {
        if (player.GetComponent<Strength>().curr != 80
            || !sword.activeSelf)
            player.GetComponent<Player_Combat>().Die();

        else
        {
            dialogue_box.SetDialogue("You saved the village",clip);
            player.GetComponent<Health>().Reduce(20);
            player.GetComponent<Quests>().kill_dragon = true;
            gameObject.SetActive(false);
        }
    }
}
