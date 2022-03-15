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
        float[] FuelRatio = new float[] {75.0f, 100.0f, 150.0f, 300.0f, 1500.0f};

        FuelLevel = LevelStorage.GetFuel();
        Fuel_Max = FuelRange * FuelRatio[FuelLevel - 1];
        Fuel = Fuel_Max;
    }



    // Update is called once per frame
    void Update()
    {
        float NeedleRotate;
        float RotateRate;

        if (Input.GetMouseButton(2))
        {
            //Debug.Log("Pushing");

            Fuel -= Time.deltaTime;
            if (Fuel < 0.0f)
            {
                Fuel = 0.0f;
            }

            RotateRate = 240.0f / Fuel_Max;
            NeedleRotate = (RotateRate * Time.deltaTime);

            if (Fuel > 0.0f)
            {
                GameObject.Find("Needle_Fuel").GetComponent<RectTransform>().Rotate(0.0f, 0.0f, NeedleRotate);
            }

        }

        Debug.Log(Fuel);
    }
}
