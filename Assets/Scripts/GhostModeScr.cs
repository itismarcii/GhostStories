using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(GhostScr))]
public class GhostModeScr : MonoBehaviour
{
    GhostScr ghostScr;
    public GameObject[] players;

    public int minSanityAmount;          //Maybe set over Ghost Scriptable
    public int encounterDistance;
    int frames = 0;

    private void Start()
    {
        ghostScr = GetComponent<GhostScr>();
        ghostScr.ghost.mode = GhostScritable.Mode.passive;
        players =  GameObject.FindGameObjectsWithTag("Player");
    }

    private void Update()
    { 
        //Check the Sanity for each Player after a certain amount of frames
        if (frames % 200 == 0) { CheckPlayersSanity(); }  
        if (frames % 25 == 0) { PlayerNearby(); }

        switch(ghostScr.ghost.mode)
        {
            case GhostScritable.Mode.passive:
                ghostScr.Patrol();
                break;
            case GhostScritable.Mode.aggressive:
                //ghostScr.Follow();     //Needs to Follow player
                break;
        }

        frames++;
    }

    // Checks Players Sanitylevel and follows one random if "> 0" have a too high Sanity
    void CheckPlayersSanity()
    {
        List<GameObject> player = new List<GameObject>();

        foreach(GameObject p in players) {

            var ply = p.GetComponent<PlayerLocomotionScr>().player;

            if (ply.sanity <= minSanityAmount)
            {
                ghostScr.ghost.mode = GhostScritable.Mode.aggressive;
                player.Add(p);
            }
        }

        if (ghostScr.ghost.mode == GhostScritable.Mode.aggressive)
        {
            var thisP = player[Random.Range(0, player.Count)];
            ghostScr.Follow(thisP.transform);
            ghostScr.followThis = thisP;
        }
    }

    void PlayerNearby()
    {
        if (!ghostScr.followThis)
        {
            foreach (GameObject p in players)
            {
                if (Mathf.Abs(Vector3.Distance(p.transform.position, transform.position)) <= encounterDistance)
                {
                    ghostScr.Follow(p.transform);
                    ghostScr.followThis = p;
                    break;
                }
                else
                {
                    ghostScr.followThis = null;
                }
            }
        }
    }
}