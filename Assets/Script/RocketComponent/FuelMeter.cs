using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelMeter : MonoBehaviour
{
    private float Fuel_Max;
    private float Fuel;

    // Start is called before the first frame update
    void Start()
    {
        int FuelLevel = 1;

        FuelLevel = LevelStorage.GetFuel();

        if (FuelLevel == 1)
        {
            Fuel_Max = 30.0f;
            Fuel = Fuel_Max;
        }
        else if (FuelLevel == 2)
        {
            Fuel_Max = 40.0f;
            Fuel = Fuel_Max;
        }
        else if (FuelLevel == 3)
        {
            Fuel_Max = 50.0f;
            Fuel = Fuel_Max;
        }
        else if (FuelLevel == 4)
        {
            Fuel_Max = 60.0f;
            Fuel = Fuel_Max;
        }
        else if (FuelLevel == 5)
        {
            Fuel_Max = 120.0f;
            Fuel = Fuel_Max;
        }
    }



    // Update is called once per frame
    void Update()
    {
        float NeedleRotate;
        float RotateRatio;

        if (Input.GetMouseButtonDown(2))
        {
            Debug.Log("ホイールクリックしたよ！");
            Fuel -= Time.deltaTime;
            if (Fuel < 0)
            {
                Fuel = 0.0f;
            }
        }

        RotateRatio = 240.0f / Fuel_Max;
        NeedleRotate = (RotateRatio * Fuel) - 120.0f;

        GetComponent<Needle>().RectTransform.Rotate = new Vector3(0, 0, NeedleRotate);
    }
}
