using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : Interactable{

    [SerializeField] private Storage storage;
    [SerializeField] private Dialogue dialogue_box;
    [SerializeField] private GameObject[] waypoints;
    int curr = 0;
    [SerializeField] private float speed = 10f;
    public AudioClip[] clip;

    private void Update(){
        if (Vector3.Distance(transform.position, waypoints[curr].transform.position)
            < 0.1f)
        {
            curr = 1 - curr;
            ChangeDirection();
        }

        transform.position = Vector3.MoveTowards(transform.position,
                                                 waypoints[curr].transform.position,
                                                 speed * Time.deltaTime);
    }

    private void ChangeDirection(){
        Vector3 relativePos = waypoints[curr].transform.position - transform.position;
        transform.rotation = Quaternion.LookRotation(relativePos);
    }

    public override string GetDescription(){
        return "Press [E] to grab";
    }
    public override void Interact()
    {   
        storage.Add(1);
        if (storage.fish == 1) dialogue_box.SetDialogue("Fish tastes better than rabbits.",clip[0]);
        else dialogue_box.SetDialogue("You feel calm and satisfied.",clip[1]);
        gameObject.SetActive(false);
    }
}
