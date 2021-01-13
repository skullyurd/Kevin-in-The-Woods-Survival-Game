using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turn_off : MonoBehaviour
{

    public GameObject self;
    // Start is called before the first frame update
    void Start()
    {
        self.SetActive(false);
    }
}
