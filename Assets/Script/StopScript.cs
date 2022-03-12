using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopScript : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("hit");
        this.GetComponent<Lander>().enabled = false;
    }
}
