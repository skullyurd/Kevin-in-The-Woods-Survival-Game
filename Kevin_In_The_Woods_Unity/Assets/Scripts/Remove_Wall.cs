using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Remove_Wall : MonoBehaviour
{
    Health Player_stats;

    public GameObject RemoveWall;

    MeshRenderer wall;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        wall = RemoveWall.GetComponent<MeshRenderer>();
        Player_stats = GameObject.Find("Player_holder").GetComponent<Health>();
    }

    void OnTriggerEnter(Collider other)
    {
        wall.enabled = !wall.enabled;
        Player_stats.krijg_warm = true;
    }
    void OnTriggerExit(Collider other)
    {
        wall.enabled = !wall.enabled;
        Player_stats.krijg_warm = false;
    }

}
