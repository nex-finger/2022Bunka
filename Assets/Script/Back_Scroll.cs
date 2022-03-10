using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back_Scroll : MonoBehaviour
{
    private int x, y;
    public float Lengthx, Lengthy;

    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        y = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Rocket_place;

        Rocket_place = GameObject.Find("Rocket").transform.position;

        if (Rocket_place.x > (x * Lengthx + Lengthx))
        {
            GameObject.Find("hosizora_main").transform.position += new Vector3(Lengthx, 0, 0);
            x += 1;
        }
        else if (Rocket_place.x < (x * Lengthx - Lengthx))
        {
            GameObject.Find("hosizora_main").transform.position += new Vector3(-Lengthx, 0, 0);
            x -= 1;
        }

        if (Rocket_place.y > (y * Lengthy + Lengthy))
        {
            GameObject.Find("hosizora_main").transform.position += new Vector3(0, Lengthy, 0);
            y += 1;
        }
        else if (Rocket_place.y < (y * Lengthy - Lengthy))
        {
            GameObject.Find("hosizora_main").transform.position += new Vector3(0, -Lengthy, 0);
            y -= 1;
        }
    }
}
