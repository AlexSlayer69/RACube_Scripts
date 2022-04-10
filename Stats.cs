using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Stats : MonoBehaviour {

    [SerializeField] public float max;
    public float curr;
    public abstract void Reduce(float amount);
    public abstract void Increase(float amount);
}
