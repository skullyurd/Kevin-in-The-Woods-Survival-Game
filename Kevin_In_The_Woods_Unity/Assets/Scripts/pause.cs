using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class pause : MonoBehaviour
{
    bool INV_on;

    public GameObject pause_screen;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            INV_on = !INV_on;
        }
        if (INV_on == true)
        {
            pause_screen.SetActive(true);
            Time.timeScale = 0;
        }
        if (INV_on == false)
        {
            pause_screen.SetActive(false);
            Time.timeScale = 1;
        }
    }
    public void return_game()
    {
        INV_on = false;
    }
    public void quit_game()
    {
        Application.Quit();
    }
}
