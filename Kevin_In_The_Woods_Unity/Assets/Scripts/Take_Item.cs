using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Take_Item : MonoBehaviour
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
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Berry")
        {
            script_health.Berry_N++;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.name == "Oli")
        {
            script_health.Oil_N++;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.name == "Bandage")
        {
            script_health.Bandage_N++;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.name == "Chicken")
        {
            script_health.Chicken_N++;
            Destroy(collision.gameObject);
        }
    }
}
