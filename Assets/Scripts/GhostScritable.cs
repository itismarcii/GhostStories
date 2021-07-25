using UnityEngine;

[CreateAssetMenu(fileName = "New Ghost", menuName = "Ghost")]
public class GhostScritable : ScriptableObject
{
    public class Sanity
    {
        public float loseTime;
        public float loseAmount;
    }

    public class Abilities
    {
        public bool teleport = false;
        public bool scream = false;
        public bool lightActivity = false;
        public bool objectInteraction = false;
        public bool appearanceFlicker = false;
        public bool charge = false;
    }

    public enum Mode
    {
        passive,
        present,
        active,
        aggressive,
        hunting
    }

    public enum Ghost
    {
        standard
    }

    public Ghost ghost;
    public Sanity sanity;
    public Mode mode;
    public Abilities abilities;
    public Movement movement;
}
