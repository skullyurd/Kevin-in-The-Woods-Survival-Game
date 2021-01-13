using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    public Transform SlotIconGO;

    public GameObject item;
    public int ID;
    public string type;
    public string description;
    public Sprite icon;
    public bool empty;

    public void Start()
    {
        SlotIconGO = transform.GetChild(0);
    }

    public void UpdateSlot()
    {
        SlotIconGO.GetComponent<Image>().sprite = icon;
    }

    public void UseItem()
    {

    }
}