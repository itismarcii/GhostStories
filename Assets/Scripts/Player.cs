using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Player", menuName ="Player")]
public class Player : ScriptableObject
{
    public string playerName;
    public Player(string playerName)
    {
        this.playerName = playerName;
    }

    public string id;
    public Movement movement;
    [Range(1,100)] public int sanity = 100;
    public bool isHunted = false;
}
