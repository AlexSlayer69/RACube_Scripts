using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour{

    [SerializeField] private float Jump_Velocity;
    [SerializeField] private float velocity;
    [SerializeField] private float gravity;
    [SerializeField] private Transform check;
    [SerializeField] private float ground_distance;
    [SerializeField] private LayerMask groundlayer;

    private CharacterController controller;
    private Animator anim;
    private Vector3 gravity_vel;
    private Hunger hunger;

    void Start(){
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
        hunger = GetComponent<Hunger>();
    }

    void Update(){

        if (IsGrounded() && gravity_vel.y < 0) gravity_vel.y = -2f;
       
        //Movement
        float x_input = Input.GetAxisRaw("Horizontal");
        float z_input = Input.GetAxisRaw("Vertical");
        if (x_input > 0.1f || z_input > 0.1f) anim.SetBool("IsRunning", true);
        else anim.SetBool("IsRunning",false);
        Vector3 move = transform.right * x_input + transform.forward * z_input;
        controller.Move(move * velocity * Time.deltaTime);

        //Jumping
        if (Input.GetButtonDown("Jump") && IsGrounded()){
            gravity_vel.y = Jump_Velocity;
            hunger.Reduce(5);
        }

        //Gravity
        gravity_vel.y += gravity*Time.deltaTime;
        controller.Move(gravity_vel * Time.deltaTime);

    }

    private bool IsGrounded(){
        return Physics.CheckSphere(check.position,ground_distance,groundlayer);
    }
}
