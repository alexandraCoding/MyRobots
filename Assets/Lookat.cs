using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lookat : MonoBehaviour
{

    
    public GameObject city;
    void Start()
    {
        this.transform.LookAt(city.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
