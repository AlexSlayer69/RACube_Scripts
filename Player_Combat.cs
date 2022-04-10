using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Combat : MonoBehaviour
{
    private Health health;
    private Strength strength;
    private Hunger hunger;
    private Animator anim;
    [SerializeField] private GameObject sword;
 
    void Start(){
        hunger = GetComponent<Hunger>();
        anim = GetComponent<Animator>();
        health = GetComponent<Health>();
    }

    void Update(){
        if(health.curr <= 0) Die();

        if (Input.GetKeyDown(KeyCode.R)) Die();

        if (Input.GetKeyDown(KeyCode.G)){
            anim.SetTrigger("Attack");
            hunger.Reduce(1);
        }
    }

    public void Die(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
