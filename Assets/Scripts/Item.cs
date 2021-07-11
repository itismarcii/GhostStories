using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Items")]
public class Item : ScriptableObject
{
    public enum ItemUsage
    {
        Lighter,
        LighterFuel,
        LightBulb,
        Radio,
        Batterie,
        QuestItem
    }

    public ItemUsage itemName;

    public bool active = false;
    public bool lightSource;
    public bool refilable;
    public bool hasDurability;

    [System.Serializable]
    public class Durability
    {
        [Range(1, 100)] public int maxAmount;
        [Range(1f, 100f)] public float amount;
        [Range(.01f, 20f)] public float refilableTime;
        [Range(.01f, 20f)] public float refilableAmount;
        [Range(.01f, 20f)] public float loseTime;
        [Range(.01f, 20f)] public float loseAmount;

        Item refileItem;
    }
    public Durability durability;
}
