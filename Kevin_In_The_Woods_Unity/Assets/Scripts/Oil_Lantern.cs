using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oil_Lantern : MonoBehaviour
{

    public Light lantern;
    public GameObject scare_field;

    // Start is called before the first frame update
    void Start()
    {
        lantern.intensity = 10;
    }

    // Update is called once per frame
    void Update()
    {
        lantern.intensity -= 0.2f * Time.deltaTime;
    }
}
