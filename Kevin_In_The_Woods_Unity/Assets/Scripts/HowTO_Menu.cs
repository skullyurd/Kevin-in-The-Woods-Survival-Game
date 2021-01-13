using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowTO_Menu : MonoBehaviour
{

    public int page;

    public GameObject page1;
    public GameObject page2;
    public GameObject page3;

    public GameObject arrow_up;
    public GameObject arrow_down;

    // Update is called once per frame
    void Update()
    {

        if(page < 1)
        {
            page = 1;
        }
        if(page > 3)
        {
            page = 3;
        }

        if(page == 1)
        {
            page1.SetActive(true);
            page2.SetActive(false);
            page3.SetActive(false);

            arrow_down.SetActive(false);
            arrow_up.SetActive(true);
        }
        if (page == 2)
        {
            page1.SetActive(false);
            page2.SetActive(true);
            page3.SetActive(false);

            arrow_down.SetActive(true);
            arrow_up.SetActive(true);
        }
        if (page == 3)
        {
            page1.SetActive(false);
            page2.SetActive(false);
            page3.SetActive(true);

            arrow_down.SetActive(true);
            arrow_up.SetActive(false);
        }

    }
    public void add_Page()
    {
        page++;
    }
    public void decrease_Page()
    {
        page--;
    }
}
