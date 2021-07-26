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
    float animationDurationOpen = 0;
    bool isDoorOpen = false;

    //Coroutine
    bool AMDelay = false;

    //Event
    bool animationGoing = false;

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
                animationDurationOpen = c.length;
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
                //Add Ghost Choice if it wants to close the door
                //CloseDoor();
                break;
        }
    }

    public void DoorHandling()
    {
        if (!animationGoing)
        {
            switch (isDoorOpen)
            {
                case true:
                    CloseDoor();
                    break;
                case false:
                    OpenDoor();
                    break;
            }
        }
    }

    void OpenDoor()
    {
        if (!isDoorOpen)
        {
            animator.SetTrigger("Open");
        }
    }

    void OpenDoor(GameObject obj)
    {
        if (!isDoorOpen)
        {
            var agent = obj.GetComponent<NavMeshAgent>();
            agent.isStopped = true;
            animator.SetTrigger("Open");
            StartCoroutine(AgentMovementDelay_(agent, animationDurationOpen));
        }
    }

    void CloseDoor()
    {
        if (isDoorOpen)
        {
            animator.SetTrigger("Close");
        }
    }
    public void DoorBool(int isBool)
    {
        switch (isBool)
        {
            case 0:
                isDoorOpen = false;
                break;
            case 1:
                isDoorOpen = true;
                break;
        }

        animationGoing = false;
    }

    public void AnimationStartDoor()
    {
        animationGoing = true;
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
