using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quests : MonoBehaviour
{
    private Storage storage;
    public bool kill_guard;
    public int kill_count = 0;
    public bool kill_dragon;
    public bool kill_bear;
    public bool no_rabbits;
    [SerializeField] private GameObject guard;
    [SerializeField] private Menu Ending;
    void Start(){
        storage = GetComponent<Storage>();
    }

    void Update(){   
        if(storage.coins == 110 && !kill_guard && !guard.activeSelf){
            Ending.show(true);
            Ending.SetEnding("Ending 1- This way Adu lived a normal but fulfilled life with the common ups and downs but thriving on his own.",null);
        }
        else if(kill_count == 6){
            Ending.show(true);
            Ending.SetEnding(" He killed his own father and tried to rule as king but the citizens rejected him.He killed them too " +
                "He was banished to the streets instead of being sentenced for life and he wandered along in his loneliness in the forest.", null);
        }
        else if (kill_dragon && storage.coins < 110){
            Ending.show(true);
            Ending.SetEnding("He killed the bear and the dragon saving the other animals. " +
                "The animals considered him their king and in some way he became king although not of what he had initially thought :)", null);
        }
        else if (kill_bear){
            Ending.show(true);
            Ending.SetEnding("He killed the bear but lived on constantly in fear of being hunted by the dragon and wanting to return to his palace", null);
        }
        else if(storage.coins == 110 && kill_guard && kill_dragon && kill_bear){
            Ending.show(true);
            Ending.SetEnding("After killing the guards, the king issued an order to kill the culprit " +
                "but he kept evading them and kept sabotaging the order of the king for generations and created a brotherhood (assassin’s creed ref) " +
                "to take down the order of the king", null);
        }
        else if(no_rabbits && kill_count == 0 && storage.apple == 5){
            Ending.show(true);
            Ending.SetEnding("Adu became george of the jungle feeding on only apples and feeding his ‘animal subjects’ ", null);
        }
        else if(storage.coins == 110 && kill_dragon){
            Ending.show(true);
            Ending.SetEnding(" He became the king although he had the skills to become a king. He failed sometimes at empathising with his subjects.", null);
        }
        else if(storage.fish == 3 && no_rabbits &&  !kill_dragon && !kill_guard && !kill_bear){
            Ending.show(true);
            Ending.SetEnding("From this game, although the endings are crazy,it can truly be said that ‘what you make is what you eat’ he ate apples, required food items in order to become who he is, " +
                "but the forest made him ‘eat’ experience and rough times which either made him or break him depending on how you went about it." +
                "Also Congratulations on finding the Fish Ending", null);
        }
    }
}
