using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Storage : MonoBehaviour{
    
    [Header("Interaction")]
    [SerializeField] private TMPro.TextMeshProUGUI cointext;
    [SerializeField] private Dialogue dialogue_box;
    public AudioClip clip1;
    public AudioClip clip2;
    public AudioClip clip3;
    public AudioClip clip4;

    [Header ("Items")]
    public int apple = 0;
    public int fish = 0;
    public int rabbits = 0;
    public int coins = 0;

    private Hunger hunger;
    private Strength strength;

    private void Start(){
        hunger = GetComponent<Hunger>();
        strength = GetComponent<Strength>();
    }

    public void Add(int item_id){
        switch (item_id){
            case 0: apple++; break;
            case 1: fish++; break;
            case 2: rabbits++; break;
            default: Debug.Log("Error"); break;
        }
    }
    public void Coins(int num){
        coins += num;
    }
    private void Update(){

        if (Input.GetKeyDown(KeyCode.F)){
            if (apple != 0)
            {
                apple--;
                hunger.Increase(5);
                dialogue_box.SetDialogue("Apple Eaten",clip1);
            }
            else if (fish != 0)
            {
                fish--;
                hunger.Increase(10);
                dialogue_box.SetDialogue("Fish Eaten",clip2);
            }
            else if (rabbits != 0)
            {
                rabbits--;
                hunger.Increase(20);
                strength.Increase(20);
                dialogue_box.SetDialogue("Rabbit Eaten",clip3);
            }
            else dialogue_box.SetDialogue("No Food is left",clip4);
        }

        cointext.text = "" + coins;
    }
}
