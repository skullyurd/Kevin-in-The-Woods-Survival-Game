using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buton_Manager : MonoBehaviour
{

    public GameObject Inventory;
    bool INV_on = false;

    int AllSlots;
    int EnableSlots;
    GameObject[] Slot;

    public GameObject SlotHolder;

    // Start is called before the first frame update
    void Start()
    {

        Inventory = GameObject.Find("Inventory");
        SlotHolder = GameObject.Find("Slot_Holder");


        AllSlots = 78;
        Slot = new GameObject[AllSlots];

        for (int i = 0; i < AllSlots; i++)
        {
            Slot[i] = SlotHolder.transform.GetChild(i).gameObject;

            if (Slot[i].GetComponent<Slot>().item == null)
                Slot[i].GetComponent<Slot>().empty = true;
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.I))
        {
            INV_on = !INV_on;
        }
        if (INV_on == true)
        {
            Inventory.SetActive(true);
            Time.timeScale = 0;
        }
        if (INV_on == false)
        {
            Inventory.SetActive(false);
            Time.timeScale = 1;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Item")
        {
            GameObject itemPickedUp = other.gameObject;
            Item item = itemPickedUp.GetComponent<Item>();

            AddItem(itemPickedUp, item.ID, item.type, item.description, item.icon);
        }
    }

    void AddItem(GameObject itemObject, int itemID, string itemType, string itemDescription, Sprite itemIcon)
    {
        for (int i = 0; i < AllSlots; i++)
        {
           if (Slot[i].GetComponent<Slot>().empty)
            {
                itemObject.GetComponent<Item>().pickedUp = true;

                Slot[i].GetComponent<Slot>().item = itemObject;
                Slot[i].GetComponent<Slot>().icon = itemIcon;
                Slot[i].GetComponent<Slot>().type = itemType;
                Slot[i].GetComponent<Slot>().ID = itemID;
                Slot[i].GetComponent<Slot>().description = itemDescription;

                itemObject.transform.parent = Slot[i].transform;
                itemObject.SetActive(false);

                Slot[i].GetComponent<Slot>().UpdateSlot();
                Slot[i].GetComponent<Slot>().empty = false;
            }

            return;
        }
    }
}
