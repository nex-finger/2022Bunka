using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LanderFuelMeter : MonoBehaviour
{
    private float Fuel_Max;
    private float Fuel;
    private float TotalFuel;
    public float FuelRange;
    private bool Flag;

    // Start is called before the first frame update
    void Start()
    {
        Fuel_Max = FuelMeter.GetFuel_Max();
        Fuel = FuelMeter.GetFuel();

        TotalFuel = Fuel_Max - Fuel;
        GameObject.Find("Needle_Fuel").GetComponent<RectTransform>().Rotate(0.0f, 0.0f, ((240.0f / Fuel_Max) * TotalFuel));
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
