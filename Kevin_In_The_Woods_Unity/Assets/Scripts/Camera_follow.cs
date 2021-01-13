using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_follow : MonoBehaviour
{

    public Transform player;
    public float smooth = 0.3f;

    public float height;

    public AudioSource howl;

    private Vector3 velocity = Vector3.zero;

    void Start()
    {
        howl.Play();
    }

    void Update()
    {
        Vector3 pos = new Vector3();
        pos.x = player.position.x;
        pos.z = player.position.z - 7;
        pos.y = player.position.y + height;
        transform.position = Vector3.SmoothDamp(transform.position, pos, ref velocity, smooth);
    }
}