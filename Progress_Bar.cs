using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Progress_Bar : MonoBehaviour
{
    [SerializeField] private Stats playerstat;
    [SerializeField] private Image total;
    [SerializeField] private Image current;

    void Start(){
        total.fillAmount = playerstat.max/100;
    }

    void Update(){
        current.fillAmount = playerstat.curr/100; 
    }

}
