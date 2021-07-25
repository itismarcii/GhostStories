using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class GhostScr : MonoBehaviour
{
    #region - Parameters -
    NavMeshAgent agent;
    

    public GhostScritable ghost;
    public GameObject[] patrollpoints;

    Vector3 destination;
    #endregion

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(transform.position);
        destination = transform.position;

        agent.speed = ghost.movement.walkSpeed;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                destination = hit.point;
                agent.SetDestination(hit.point);
            }
        }

        if(Mathf.Abs(Vector3.Distance(destination, transform.position)) <= 3) {
            int rng = Random.Range(0, patrollpoints.Length);
            agent.SetDestination(patrollpoints[rng].transform.position);
            destination = patrollpoints[rng].transform.position;
        }
    }
}
