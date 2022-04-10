using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour
{
    [SerializeField] Quests q;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Sword")){
            q.kill_count++;
            gameObject.SetActive(false);
        }
    }
}
