using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ClickToMove : MonoBehaviour
{
    public LayerMask layerMask;
    private NavMeshAgent navMeshAgent;
    RaycastHit hitInfo = new RaycastHit();

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(myRay, out hitInfo, 1000))
            {
                navMeshAgent.destination = hitInfo.point; 
            }
        }
    }
}
