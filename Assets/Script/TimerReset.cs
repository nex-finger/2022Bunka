using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerReset : MonoBehaviour
{
    private float a;

    // Start is called before the first frame update
    void Start()
    {
        a = LevelStorage.GetTotalTime(1);
    }
}
