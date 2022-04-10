using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : Interactable
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject sword;
    [SerializeField] private Dialogue dialogue_box;
    public AudioClip clip;
    public override string GetDescription()
    {
        return "Press [E] to EAT";
    }
    public override void Interact()
    {
        player.GetComponent<Strength>().Increase(20f);
        sword.SetActive(true);
        dialogue_box.SetDialogue("Why would you eat a rock.Oh well you increased strength and gained a weapon",clip);
        gameObject.SetActive(false);
    }
}
