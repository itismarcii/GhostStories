using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScr : MonoBehaviour
{
    public Item item;
    LayerMask mask;

    bool refill = false;
    bool isClear = false;

    float max;
    float refillAmount;
    float loseAmount;

    private void Start()
    {
        mask.value = 8;
        max = item.durability.maxAmount;
        refillAmount = item.durability.refillableAmount;
        loseAmount = item.durability.loseAmount;
    }

    private void Update()
    {
        if(item.active && !refill && item.hasDurability)
        {
            StartCoroutine(LoseDurability_());
        }
    }

    public void ActivateItem(GameObject refile)
    {
        StartCoroutine(Refill_(refile));
    }

    public void ActivateItem()
    {
        item.active = true;
    }

    public void Refile(GameObject obj)
    {
        if(item.hasDurability && !item.active && obj.GetComponent<Item>().itemName == item.refillableItem)
        {
            StartCoroutine(Refill_(obj));
        }
    }

    IEnumerator Refill_(GameObject obj)
    {
        Item refillItem = obj.GetComponent<Item>();

        if (refillItem.durability.amount >= refillItem.durability.maxAmount)
        {
            if (refill)
            {
                yield break;
            }

            refill = true;
            yield return new WaitForSeconds(item.durability.refillableTime);
            refill = false;

       
            item.durability.amount -= refillAmount;

            if (item.durability.amount > 0)
            {
                refillItem.durability.amount += refillAmount;

                if (refillItem.durability.amount > max)
                {
                    refillItem.durability.amount = max;
                }
            }
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
}
