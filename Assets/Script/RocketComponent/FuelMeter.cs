using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FuelMeter : MonoBehaviour
{
    public static float Fuel_Max;
    public static float Fuel;
    public float FuelRange;
    private bool Flag;

    public static float GetFuel()
    {
        return Fuel;
    }

    public static float GetFuel_Max()
    {
        return Fuel_Max;
    }

    // Start is called before the first frame update
    void Start()
    {
        int FuelLevel = 1;
        float[] FuelRatio = new float[] { 30.0f, 40.0f, 60.0f, 120.0f, 500.0f };

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
                SceneManager.LoadScene("GameOver2");
            }

            RotateRate = 240.0f / Fuel_Max;
            NeedleRotate = (RotateRate * Time.deltaTime);

            if (Fuel > 0.0f)
            {
                GameObject.Find("Needle_Fuel").GetComponent<RectTransform>().Rotate(0.0f, 0.0f, NeedleRotate);
            }

        }

        //Debug.Log(Fuel);
    }
}
