using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IStatus
{
    public int hp=3;
    public int MaxHp=3;
    public int mp=3;
    public int MaxMp=3;
    public string master;
    bool died;

    

    public IStatus()
    {
    }

    public void GetDamage(int damge)
    {

        if (hp - damge <= 0)
        {
            hp = 0;
            died = true;
        }else
        {
            hp -= damge;

        }
        if(master=="player")
        EventManager.TriggerEvent("playerBeDamaged", new ArrayList { hp });

    }
   

    public void CostMp(int cost)
    {
        mp -= cost;
    }
   
    public bool isDied()
    {
        return died;
    }
    public void updateUI()
    {

    }
}
