using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strength :Stats{
    public override void Increase(float f){
        curr = Mathf.Clamp(curr + f,0f,max);
    }
    public override void Reduce(float amount){}
}
