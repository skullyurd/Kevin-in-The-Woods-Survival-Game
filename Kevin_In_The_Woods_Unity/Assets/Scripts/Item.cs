using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{

    public int ID;
    public string type;
    public string description;
    public Sprite icon;
    public bool pickedUp;


    [HideInInspector]
    public bool equipped;

    [HideInInspector]
    public GameObject weapon;

    [HideInInspector]
    public GameObject weaponManager;

    public bool playersweapon;

    public void Start()
    {
        if(!playersweapon)
        {

        }
    }


    public void Update()
    {
        if(equipped)
        {

        }
    }

    public void ItemUsage()
    {

        if(type == "Weapon")
        {
            equipped = true;
        }

        if (type == "Clothes")
        {

        }

        if (type == "Food")
        {

        }

    }
}
