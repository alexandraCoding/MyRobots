using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimilaWaypoint : MonoBehaviour
{
    public GameObject[] waypoints;
    int wayPointIndex = 5;
    float speed = 8.0f;
    float accuracy = 1.0f;
    float rotSpeed = 4.0f;
   
    void Start()
    {
        waypoints = GameObject.FindGameObjectsWithTag("Waypoint");
        wayPointIndex = Random.Range(0, waypoints.Length);
    }

    // Update is called once per frame
    void Update()
    {
        

        Vector3 lookAtGoal = new Vector3(waypoints[wayPointIndex].transform.position.x,
                                        this.transform.position.y,
                                        waypoints[wayPointIndex].transform.position.z);
        Vector3 direction = lookAtGoal - this.transform.position;

        this.transform.rotation = Quaternion.Slerp(this.transform.rotation,
                                                Quaternion.LookRotation(direction),
                                                Time.deltaTime * rotSpeed);
        if (direction.magnitude < accuracy)
        {
            wayPointIndex++;
            if (wayPointIndex >= waypoints.Length)
            {
                wayPointIndex = 5;
            }
        }
        this.transform.Translate(0, 0, speed * Time.deltaTime);
    }
}
