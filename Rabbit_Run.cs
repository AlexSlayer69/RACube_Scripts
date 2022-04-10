using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rabbit_Run : MonoBehaviour {
    [SerializeField] private float range;
    [SerializeField] private GameObject player;
    [SerializeField] private float speed;
    [SerializeField] private float damage;

    void Update() {
        transform.LookAt(player.transform);
        if (Vector3.Distance(transform.position, player.transform.position)
            < range){
            Vector3 trans = transform.forward * speed * Time.deltaTime;
            trans.y = 0;
            transform.position -= trans;
        }
        
    }

    private void OnCollisionEnter(Collision collision) {
        Debug.Log("Collided");
        if (collision.gameObject.CompareTag("Player")){
            player.GetComponent<Health>().Reduce(damage);
        }
    }
}