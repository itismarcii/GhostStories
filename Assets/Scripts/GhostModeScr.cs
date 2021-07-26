using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(GhostScr))]
public class GhostModeScr : MonoBehaviour
{
    GhostScr ghostScr;
    GameObject[] players;

    public int maxSanityAmout;          //Maybe set over Ghost Scriptable

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
        if (frames % 100 == 0) { CheckPlayersSanity(); }  

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

            if (ply.sanity >= maxSanityAmout)
            {
                ghostScr.ghost.mode = GhostScritable.Mode.aggressive;
                player.Add(p);
            }
        }

        if (ghostScr.ghost.mode == GhostScritable.Mode.aggressive)
        {
            ghostScr.Follow(player[Random.Range(0, player.Count)].transform);
        }
    }
}