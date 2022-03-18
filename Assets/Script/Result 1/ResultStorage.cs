using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultStorage : MonoBehaviour
{
    private int Score;
    private float Time;

    // Start is called before the first frame update
    void Start()
    {
        Score = 3000 - LevelStorage.GetCash();
        Time = LevelStorage.GetTotalTime(0);
    }
}
