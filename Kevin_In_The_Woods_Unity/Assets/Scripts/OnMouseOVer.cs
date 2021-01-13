using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnMouseOVer : MonoBehaviour
{
    public void play_game()
    {
        SceneManager.LoadScene(1);
    }
    public void quit_game()
    {
        Application.Quit();
    }
    public void HowTo()
    {
        SceneManager.LoadScene(4);
    }
    public void Back()
    {
        SceneManager.LoadScene(0);
    }
}
