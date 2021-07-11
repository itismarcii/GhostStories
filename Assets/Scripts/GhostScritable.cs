using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Ghost", menuName = "Ghost")]
public class GhostScritable : ScriptableObject
{
    public string name;
    public Movement movement;
}
