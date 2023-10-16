using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class People : MonoBehaviour
{
    //protected Color color;
    protected float stayTimeValue;
    protected Vector3 location;
    protected float multiplier;
    protected bool hasCollider(Vector3 range)
    {
        Physics.OverlapBox(transform.position, range, Quaternion.identity);
        return true; 
    }
}