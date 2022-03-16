using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeterFlag0 : MonoBehaviour
{
    public static bool MeterFlag;

    // Start is called before the first frame update
    void Start()
    {
        // メーターが中古ならtrue
        MeterFlag = false;
    }

    public static bool GetMeterFlag()
    {
        return MeterFlag;
    }

    public static void TrueMeterFlag()
    {
        MeterFlag = true;
    }

    public static void FlaseMeterFlag()
    {
        MeterFlag = false;
    }
}
