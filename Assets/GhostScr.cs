using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class GhostScr : MonoBehaviour
{
    #region - Parameters -
    public NavMeshAgent agent;
    

    public GhostScritable ghost;
    public GameObject followThis;
    public GameObject[] patrollpoints;

    Vector3 destination;

    bool isPatrollDelayRunning = false;
    public float patrollDelay = 1f;

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
    }

    public void Patrol()
    {
        if (Mathf.Abs(Vector3.Distance(destination, transform.position)) <= agent.stoppingDistance + .5f)
        {
            int rng = Random.Range(0, patrollpoints.Length);
            agent.SetDestination(patrollpoints[rng].transform.position);
            destination = patrollpoints[rng].transform.position;
            followThis = null; 
        }
    }

    //Follows Player  ---> TODO: Maybe a decay
    public void Follow(Transform obj)
    {
        agent.SetDestination(obj.position);
        destination = obj.transform.position;
    }
}
