using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.AI;

public class AiMovement : MonoBehaviour
{
    public Transform target;
    public Transform myTransform;
    public float distanceAway;
    private NavMeshAgent navCompnent;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        navCompnent = this.gameObject.GetComponent<NavMeshAgent>();

    }

    void Update()
    {
        float dist = Vector3.Distance(target.position, transform.position);

     
            navCompnent.SetDestination(target.position);
        

        
    }

   
 
    }
