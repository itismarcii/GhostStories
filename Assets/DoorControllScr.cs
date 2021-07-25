using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(Animator))]
public class DoorControllScr : MonoBehaviour
{
    #region - Paramters -

    Animator animator;
    AnimationClip[] clips;
    float animationDuration = 0;

    //Coroutine
    bool AMDelay = false;

    #endregion

    void Start()
    {
        animator = GetComponent<Animator>();
        clips = animator.runtimeAnimatorController.animationClips;

        //Sets duration for OpenDoor animation
        foreach (AnimationClip c in clips)
        {
            if (c.name == "DoorOpen")
            {
                animationDuration = c.length;
                break;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        switch (other.transform.tag)
        {
            case "Ghost":
                OpenDoor(other.gameObject);
                break;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        switch (other.transform.tag)
        {
            case "Ghost":
                CloseDoor();
                break;
        }
    }

    void OpenDoor(GameObject obj)
    {
        var agent = obj.GetComponent<NavMeshAgent>();
        agent.isStopped = true; 
        animator.SetTrigger("Open");
        StartCoroutine(AgentMovementDelay_(agent, animationDuration));
    }

    void CloseDoor()
    {
        animator.SetTrigger("Close");
    }
    IEnumerator AgentMovementDelay_(NavMeshAgent agent, float duration)
    {
        if(AMDelay) { yield break; }
        AMDelay = true;
        yield return new WaitForSeconds(duration);
        AMDelay = false;
        agent.isStopped = false;
    }
}
