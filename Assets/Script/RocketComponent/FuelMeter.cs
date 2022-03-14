using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelMeter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int FuelLevel = 1;

        FuelLevel = LevelStorage.GetFuel();

        if (FuelLevel == 1)
        {
            Fuel_Max = 30.0f;
        }
        else if (FuelLevel == 2)
        {
            Fuel_Max = 40.0f;
        }
        else if (FuelLevel == 3)
        {
            Fuel_Max = 50.0;
        }
        else if (FuelLevel == 4)
        {
            Fuel_Max = 60.0;
        }
        else if (FuelLevel == 5)
        {
            Fuel_Max = 120.0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
