using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Walk : MonoBehaviour
{
    [SerializeField] private GameObject[] waypoints;
    int curr = 0;
    [SerializeField] private float speed = 10f;
    private void Update()
    {
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

}