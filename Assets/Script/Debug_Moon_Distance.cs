using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Debug_Moon_Distance : MonoBehaviour
{
    public Text TextFrame;
    private Vector3 Moon_place;
    private float Distance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Moon_place = GameObject.Find("Moon_tmp").transform.position;
        Distance = Mathf.Sqrt(Moon_place.x * Moon_place.x + Moon_place.y * Moon_place.y);

        TextFrame.text = string.Format("{0:F2} Distance", Distance);
    }
}
