using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open_door : MonoBehaviour {

    public GameObject door;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            door.transform.Rotate(new Vector3(0, 0, 7) * 12.5f);
        }
    }
    void OnTriggerExit(Collider other)
    {
        door.transform.Rotate(new Vector3(0, 0, -7) * 12.5f);
    }
}
