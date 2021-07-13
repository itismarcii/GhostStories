using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryScr : MonoBehaviour
{
    [Range(1,10)] public int maxSize;
    [HideInInspector] public int position;
    public List<Item> inventory;            //Later HideInInspector


    public void AddInInventory(Item item)
    {
        if (inventory.Count < maxSize)
        {
            if (!inventory.Contains(item))
            {
                inventory.Add(item);
            }
        }
    }

    public void RemoveFromInventory(Item item)
    {
        foreach(Item i in inventory)
        {
            if(i == item)
            {
                inventory.Remove(i);
                break;
            }
        }
    }

    public bool InvenotryFull()
    {
        if(inventory.Count >= maxSize)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
