using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayBootimes : MonoBehaviour
{
    public Text TextValue;
    private int Value;

    // Start is called before the first frame update
    void Start()
    {
        Value = PlayerPrefs.GetInt("BootTimes");
        TextValue.text = string.Format("{0}", Value);
    }
}