using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    Vector3 Rocket;
    Vector3 Camera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rocket = GameObject.Find("Rocket").transform.position;
        Camera = GameObject.Find("Main Camera").transform.position;

        GameObject.Find("Main Camera").transform.position = new Vector3(Rocket.x, Rocket.y, Camera.z);
    }
}
