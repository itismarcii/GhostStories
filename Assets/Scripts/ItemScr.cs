using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScr : MonoBehaviour
{
    public Item item;

    bool refile = false;
    bool defile = false;

    float max;
    float refileAmount;
    float loseAmount;

    private void Start()
    {
        max = item.durability.maxAmount;
        refileAmount = item.durability.refilableAmount;
        loseAmount = item.durability.loseAmount;
    }

    private void Update()
    {
        if(item.active && !refile)
        {
            StartCoroutine(LoseDurability_());
        }
    }

    public void Refile()
    {
        if(item.hasDurability && !item.active)
        {
            StartCoroutine(Refile_());
        }
    }

    IEnumerator Refile_()
    {
        if(refile)
        {
            yield break;
        }
        refile = true;
        yield return new WaitForSeconds(item.durability.refilableTime);
        refile = false;
        item.durability.amount += refileAmount;
        if(item.durability.amount > max)
        {
            item.durability.amount = max;
        }
    }

    IEnumerator LoseDurability_()
    {
        if (defile)
        {
            yield break;
        }
        defile = true;
        yield return new WaitForSeconds(item.durability.loseTime);
        defile = false;
        item.durability.amount -= loseAmount;
        if (item.durability.amount < 0)
        {
            item.durability.amount = 0;
            item.active = false;
        }
    }
}
