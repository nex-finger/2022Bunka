using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScroll : MonoBehaviour
{
    private int x;
    public float Lengthxg;

    // Start is called before the first frame update
    void Start()
    {
        x = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Rocket_place;

        Rocket_place = GameObject.Find("Rocket").transform.position;

        if (Rocket_place.x > (x * Lengthxg + Lengthxg))
        {
            GameObject.Find("MoonSurface").transform.position += new Vector3(Lengthxg, 0, 0);
            x += 1;
        }
        else if (Rocket_place.x < (x * Lengthxg - Lengthxg))
        {
            GameObject.Find("MoonSurface").transform.position += new Vector3(-Lengthxg, 0, 0);
            x -= 1;
        }
    }
}