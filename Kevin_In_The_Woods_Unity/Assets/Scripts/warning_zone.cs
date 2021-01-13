using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warning_zone : MonoBehaviour
{

    Wolf_Movement Wolf_script;

    public AudioSource growl;

    void Start()
    {
        growl.Stop();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Wolf_script = other.gameObject.GetComponent<Wolf_Movement>();
            Wolf_script.creeping = true;
            Wolf_script.patrolling = false;
            Wolf_script.attacking = false;
            growl.Play();
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Wolf_script = other.gameObject.GetComponent<Wolf_Movement>();
            Wolf_script.patrolling = true;
            Wolf_script.creeping = false;
            Wolf_script.attacking = false;
        }
    }
}
