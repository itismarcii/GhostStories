using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Items")]
public class Item : ScriptableObject
{
    public string itemName;
    public Item(string itemName)
    {
        this.itemName = itemName;
    }

    public bool lightSource;
    public bool refilable;
    public bool hasDurability;

    [System.Serializable]
    public class Durability
    {
        [Range(1, 100)] public int maxAmount;
        [Range(1f, 100f)] public float amount;
        [Range(.01f, 20f)] public float refilableTime;
        [Range(.01f, 20f)] public float loseTime;
    }
    public Durability durability;
}
