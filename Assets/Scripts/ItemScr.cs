using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScr : MonoBehaviour
{
    public Item item;
    LayerMask mask;

    bool refill = false;
    bool isClear = false;

    float loseAmount;


    private void Start()
    {
        mask.value = 8;
        loseAmount = item.durability.loseAmount;
    }

    private void Update()
    {
        if(item.active && !refill && item.hasDurability)
        {
            StartCoroutine(LoseDurability_());
        }
        if(item.lightSource)
        {
            Light();
        }
    }

    public void ActivateItem()
    {
        if (item.durability.amount > 0)
        {
            item.active = true;
            switch (item.item)
            {
                case Item.ItemUsage.Lighter:
                    break;
                case Item.ItemUsage.LightBulb:
                    break;
                case Item.ItemUsage.Radio:
                    break;
            }
        }
    }

    public void ActivateItem(Item i)
    {
        if (item.durability.amount > 0)
        {
            switch (item.item)
            {
                case Item.ItemUsage.LighterFuel:
                    if (i.item == item.refillableItem)
                    {
                        Refill(i);
                    }
                    break;
                case Item.ItemUsage.LightBulb:
                    break;
                case Item.ItemUsage.Batterie:
                    if (i.item == item.refillableItem)
                    {
                        Refill(i);
                    }
                    break;
            }
        }
    }

    #region - Actives -

    void Light()
    {
        Debug.Log("glow");
    }

    public void Refill(Item i)
    {
        if (i.durability.amount < i.durability.maxAmount)
        {
            StartCoroutine(Refill_(i));
        }
        if(i.durability.amount > i.durability.maxAmount)
        {
            i.durability.amount = i.durability.maxAmount;
        }
    }

    #endregion

    #region - Coroutines -

    IEnumerator Refill_(Item i)
    {
        if (refill)
        {
            yield break;
        }
        
        refill = true;
        yield return new WaitForSeconds(item.durability.loseTime);
        refill = false;

        i.durability.amount += item.durability.loseAmount;
        item.durability.amount -= item.durability.loseAmount;

        if (item.durability.amount < 0)
        {
            item.durability.amount = 0;
        }
        
    }

    IEnumerator LoseDurability_()
    {
        if (isClear)
        {
            yield break;
        }

        isClear = true;
        yield return new WaitForSeconds(item.durability.loseTime);
        isClear = false;
        item.durability.amount -= loseAmount;

        if (item.durability.amount < 0)
        {
            item.durability.amount = 0;
            item.active = false;
        }
    }

    #endregion
}


