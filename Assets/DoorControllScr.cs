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
    Dictionary<string, float> durationLists;
    bool isDoorOpen = false;

    [Space]

    public int openAnimationCount;
    public int closeAnimationCount;


    //Coroutine
    bool AMDelay = false;

    //Event
    bool animationGoing = false;

    #endregion

    void Start()
    {
        animator = GetComponent<Animator>();
        clips = animator.runtimeAnimatorController.animationClips;
        durationLists = new Dictionary<string, float>();

        //Sets duration for OpenDoor animation
        foreach (AnimationClip c in clips)
        {
            if (c.name == "DoorOpen")
            {
                durationLists.Add("DoorOpen", c.length);
            }
            if (c.name == "DoorOpenSlow")
            {
                durationLists.Add("DoorOpenSlow", c.length);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        switch (other.transform.tag)
        {
            case "Ghost":
                int rngNum = Random.Range(0, durationLists.Count);
                OpenDoor(other.gameObject, rngNum);
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

    void OpenDoor(GameObject obj, int animationNumber)
    {

        if (!isDoorOpen)
        {
            var agent = obj.GetComponent<NavMeshAgent>();
            agent.isStopped = true;
            animator.SetInteger("Random", animationNumber);
            animator.SetTrigger("Open");
            float duration = SelectAnimationOpenDoor(animationNumber);
            StartCoroutine(AgentMovementDelay_(agent, duration));
        }
    }

    float SelectAnimationOpenDoor(int animationNumber)
    {
        switch(animationNumber)
        {
            case 0:
                return durationLists["DoorOpen"];
            case 1:
                return durationLists["DoorOpenSlow"];
        }
        return 0;
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
