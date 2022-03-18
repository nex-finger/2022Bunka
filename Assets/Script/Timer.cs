using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text TextTimer;
    private float TimeTimer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        TimeTimer = LevelStorage.GetTotalTime(0);
        TextTimer.text = string.Format("{0}", TimeTimer);
    }
}
