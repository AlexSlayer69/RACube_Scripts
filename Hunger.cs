using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hunger : Stats { 
    public override void Reduce(float amount){
        curr = Mathf.Clamp(curr-amount,0f,max);
    }

    public override void Increase(float amount){
        curr = Mathf.Clamp(curr + amount, 0f, max);
    }
}
