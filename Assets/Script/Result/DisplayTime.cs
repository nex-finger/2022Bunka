using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayTime : MonoBehaviour
{
    public Text TextTime;
    private float Time;

    // Start is called before the first frame update
    void Start()
    {
        Time = LevelStorage.GetTotalTime(0);
        TextTime.text = string.Format("{0}", Time);
    }
}