using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrollScr : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        switch(other.transform.tag)
        {
            case "Ghost":
                StartCoroutine(Delay_(other.GetComponent<GhostScr>()));
                break;
        }
    }

    IEnumerator Delay_(GhostScr obj)
    {
        obj.agent.isStopped = true;
        yield return new WaitForSeconds(obj.patrollDelay);
        obj.agent.isStopped = false;
    }
}
