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
            //Game Ending 1
        }
        else if(kill_count == 6){
            //Game Ending 2
        }
        else if (kill_dragon && storage.coins < 110){
            //Ending 3
        }
        else if (kill_bear){
            //Ending 4
        }
        else if(storage.coins == 110 && kill_guard && kill_dragon && kill_bear){
            //Ending 5
        }
        else if(no_rabbits && kill_count == 0 && storage.apple == 5){
            //Ending 6
        }
        else if(storage.coins == 110 && kill_dragon){
            //Ending 7
        }
        else if(storage.fish == 3 && no_rabbits &&  !kill_dragon && !kill_guard && !kill_bear){
            //Ending 8
        }
    }
}
