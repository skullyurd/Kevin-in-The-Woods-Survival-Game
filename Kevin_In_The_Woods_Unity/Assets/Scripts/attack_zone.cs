using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack_zone : MonoBehaviour
{

    public AudioSource bark;

    void Start()
    {
        bark.Stop();
    }

    Wolf_Movement Wolf_script;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("in");
            Wolf_script = other.gameObject.GetComponent<Wolf_Movement>();
            Wolf_script.creeping = false;
            Wolf_script.patrolling = false;
            Wolf_script.attacking = true;
            bark.Play();
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("uit");
            Wolf_script = other.gameObject.GetComponent<Wolf_Movement>();
            Wolf_script.patrolling = true;
            Wolf_script.creeping = false;
            Wolf_script.attacking = false;
            bark.Stop();
        }
    }
}