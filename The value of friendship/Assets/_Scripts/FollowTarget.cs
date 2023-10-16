using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; 

public class FollowTarget : MonoBehaviour
{
    [SerializeField] Transform target;
    NavMeshAgent agent;
    public bool startFollow; 

    void Start()
    {
        target = GameObject.Find("Player").transform;
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false; 
    }

    void Update()
    {
        if (startFollow)
        {
            agent.SetDestination(target.position); 
        }
    }
}
