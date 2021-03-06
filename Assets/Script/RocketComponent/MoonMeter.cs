using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoonMeter : MonoBehaviour
{
    private float LanderLevel;
    private Vector2 RocketPlace, MoonPlace;
    private float Distance;
    private float Rotate1, Rotate2;
    private float MeterMax = 25.0f;

    // Start is called before the first frame update
    void Start()
    {
        LanderLevel = LevelStorage.GetLander();
        Rotate1 = 0.0f;
        Rotate2 = 0.0f;

        if (LanderLevel == 1)
        {
            GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        float RotateRange;
        RotateRange = 240.0f / MeterMax;

        //this.GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0.0f);

        RocketPlace.x = GameObject.Find("Rocket").transform.position.x;
        RocketPlace.y = GameObject.Find("Rocket").transform.position.y;
        MoonPlace.x = GameObject.Find("Moon_tmp").transform.position.x;
        MoonPlace.y = GameObject.Find("Moon_tmp").transform.position.y;

        Distance = Mathf.Sqrt((RocketPlace.x - MoonPlace.x) * (RocketPlace.x - MoonPlace.x) + (RocketPlace.y - MoonPlace.y) * (RocketPlace.y - MoonPlace.y));
        if(Distance > MeterMax)
        {
            Distance = MeterMax;
        }

        Rotate2 = (MeterMax - Distance) * RotateRange;

        if (LanderLevel != 1)
        {
            GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0.0f);

            GameObject.Find("Needle_Moon").GetComponent<RectTransform>().Rotate(0.0f, 0.0f, -Rotate1);
            GameObject.Find("Needle_Moon").GetComponent<RectTransform>().Rotate(0.0f, 0.0f, Rotate2);
            Rotate1 = Rotate2;

            GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        }
    }
}