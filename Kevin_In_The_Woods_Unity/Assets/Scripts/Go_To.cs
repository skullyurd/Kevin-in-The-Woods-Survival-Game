using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Go_To : MonoBehaviour
{

    public Vector3 Position_Tele;

    public GameObject Player;

    public AudioSource door;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag  == "Player")
        {
            Player.transform.localPosition = Position_Tele;
            door.Play();
        }
    }
}
