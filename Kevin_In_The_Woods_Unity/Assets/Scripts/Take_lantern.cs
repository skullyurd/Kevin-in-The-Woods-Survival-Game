using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Take_lantern : MonoBehaviour
{

    public Light lantern;

    public GameObject this_lantern;
    public GameObject player_lantern;

    void OnTriggerEnter(Collider other)
    {
        lantern.intensity = 10;
        player_lantern.SetActive(true);
        Destroy(this_lantern);
    }
}
