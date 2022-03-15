using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelMeter : MonoBehaviour
{
    private float Fuel_Max;
    public static float Fuel;
    public float FuelRange;

    // Start is called before the first frame update
    void Start()
    {
        int FuelLevel = 1;

        FuelLevel = LevelStorage.GetFuel();
        float[] FuelRatio = new float[] {30.0f, 40.0f, 60.0f, 120.0f, 500.0f};

        Fuel_Max = FuelRange * FuelRatio[FuelLevel - 1];
        Fuel = Fuel_Max;
    }



    // Update is called once per frame
    void Update()
    {
        float NeedleRotate;
        float RotateRate;
        float Fueltmp;

        Fueltmp = Fuel;

        if (Input.GetMouseButton(2))
        {
            Debug.Log("Pushing");

            Fueltmp -= Time.deltaTime;
            if (Fuel < 0.0f)
            {
                Fuel = 0.0f;
                Fueltmp = 0.0f;
            }
        }

        RotateRate = 240.0f / Fuel_Max;
        NeedleRotate = (RotateRate * (Fuel - Fueltmp));

        if (Fuel > 0.0f)
        {
            this.GetComponent<RectTransform>().Rotate(0.0f, 0.0f, NeedleRotate);
        }

        Fuel = Fueltmp;

        Debug.Log(Fuel);
    }
}
