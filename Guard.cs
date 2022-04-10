using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guard : Interactable{

    [SerializeField] Quests q;
    [SerializeField] Storage storage;

    public override string GetDescription(){
        return "Press [E] to give money";
    }

    public override void Interact(){
        storage.coins = (int)0.8 * storage.coins;
        gameObject.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Sword"))
            {
                q.kill_count++;
                q.kill_guard = true;
                gameObject.SetActive(false);
            }
        }
    }
