using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanderAllow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 RocketPlace;
        RocketPlace = GameObject.Find("Rocket").transform.position;
        GameObject.Find("Allow_Moon").transform.position = RocketPlace;
    }
}
