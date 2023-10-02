using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class People : MonoBehaviour
{
    protected Color color;
    protected float stayTimeValue; 
    protected bool hasCollider(Vector3 range)
    {
        Physics.OverlapBox(transform.position, range, Quaternion.identity);
        return true; 
    }
    public abstract void SetValues(Color color, float stayTimeValue);
}

public class EasyGoingPerson : People
{


    public override void SetValues(Color color, float stayTimeValue)
    {
        
    }
}
