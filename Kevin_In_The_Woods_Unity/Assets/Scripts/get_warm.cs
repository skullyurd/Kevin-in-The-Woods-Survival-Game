using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class get_warm : MonoBehaviour
{

    Health script_health;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        script_health = Player.GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            script_health.krijg_warm = true;
        }

    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            script_health.krijg_warm = false;
        }
    }
}
