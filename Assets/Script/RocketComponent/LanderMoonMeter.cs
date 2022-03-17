using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LanderMoonMeter : MonoBehaviour
{
    private float LanderLevel;
    private float RocketPlace;
    private float Distance;
    private float Rotate1, Rotate2;
    private float MeterMax = 30.0f;

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

        RocketPlace = GameObject.Find("Rocket").transform.position.y;

        Distance = RocketPlace + 14.0f;
        if (Distance > MeterMax)
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